namespace my_banker;

internal class Debit : Card {
    private static int limit = 0;
    private static DateTime expiryDate = DateTime.Now.AddYears(5).AddMonths(8);

    internal Debit(string ownerName) : base(ownerName, "Debit", expiryDate, limit) {}

    override public string GenerateCardNum() {
        string cardNumber = "2400";

        while(cardNumber.Length < 19) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }

        return cardNumber;
    }
}
