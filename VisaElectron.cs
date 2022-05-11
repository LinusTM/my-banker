namespace my_banker;

internal class VisaElectron : Card, ICard {
    private static int limit = 10000;
    private static string[] idNumbers = {"4026", "417500", "4508", "4844", "4913", "4917"};
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal VisaElectron(string ownerName) : base(ownerName, "Visa Electron",expiryDate, limit, false) {}

    override public string GenerateCardNum() {
        string[] prefix = {"4026", "417500", "4508", "4844", "4913", "4917"};
        string cardNumber = prefix[Random.Shared.Next(0, prefix.Length)];

        while(cardNumber.Length < 16) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }

        return cardNumber;
    }
}
