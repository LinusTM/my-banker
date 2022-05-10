namespace my_banker;

class Program {
    static void Main(string[] args) {
        Card visa = new Visa("Emil Ulykkeby");

        Console.WriteLine(
            $"Owner: {visa.OwnerName}\n" +
            $"Accunt number: {visa.AccNumber}\n" +
            $"Card number: {visa.CardNumber}\n" +
            $"Expire by:{visa.ExpiryDate}\n" +
            $"Card limit: {visa.Limit}"
        );
    }
}
