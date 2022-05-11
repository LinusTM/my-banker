namespace my_banker;

internal class Visa : Card, ICard {
    private static int limit = 20000;
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal Visa(string ownerName) : base(ownerName, "Visa", expiryDate, limit, true) { }
    
    override public string GenerateCardNum() {
        string cardNumber = "4";

        while(cardNumber.Length < 16) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }

        return cardNumber;
    }
}
