namespace my_banker;

internal class VisaElectron : Card {
    private static int limit = 10000;
    private static string[] idNumbers = {"4026", "417500", "4508", "4844", "4913", "4917"};
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal VisaElectron(string ownerName) : base(ownerName, expiryDate, limit, idNumbers) {}
}
