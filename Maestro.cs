namespace my_banker;

internal class Maestro : Card {
    private static int limit = 0;
    private static DateTime expiryDate = DateTime.Now.AddYears(5).AddMonths(8);

    internal Maestro(string ownerName) : base(ownerName, "Maestro", expiryDate, limit, false) {}

    override public string GenerateCardNum() {
        string[] prefix = {"5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
        string cardNumber = prefix[Random.Shared.Next(0, prefix.Length)];

        while(cardNumber.Length < 19) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }

        return cardNumber;
    }
}
