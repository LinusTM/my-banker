namespace my_banker;

internal class Mastercard : Card {
    private static int limit = 30000;
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal Mastercard(string ownerName) : base(ownerName, "Mastercard", expiryDate, limit, true) {}

    override public string GenerateCardNum() {
        string[] prefix = {"51", "52", "53", "54", "55"};
        string cardNumber = prefix[Random.Shared.Next(0, prefix.Length)];

        while(cardNumber.Length < 16) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }

        return cardNumber;
    }
}
