namespace my_banker;

internal class Visa : Card {
    private static int limit = 20000;
    private static string[] idNumbers = {"4"};
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal Visa(string ownerName) : base(ownerName, expiryDate, limit, idNumbers) {}
}
