namespace my_banker;

internal class Mastercard : Card {
    private static int limit = 30000;
    private static string[] idNumbers = {"51", "52", "53", "54", "55"};
    private static DateTime expiryDate = DateTime.Now.AddYears(5);

    internal Mastercard(string ownerName) : base(ownerName, expiryDate, limit, idNumbers) {}
}
