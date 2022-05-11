namespace my_banker;

class Program {
    static void Main(string[] args) {
        Card visa = new Visa("Anders Andersen");
        Card visaElectron = new VisaElectron("James Jamesen");
        Card mastercard = new Mastercard("Emil Emilsen");
        Card maestro = new Maestro("Jorgen Jorgensen");
        Card debit = new Debit("J. Ulykkeby");
        
        Card[] cards = new Card[] { visa, visaElectron, mastercard, maestro, debit };
        
        foreach(Card card in cards) {
            Console.WriteLine(
                $"Type: {card.Type}\n" +
                $"Owner: {card.OwnerName}\n" +
                $"Accunt number: {card.AccNumber}\n" +
                $"Card number: {card.CardNumber}\n" +
                $"Expire by: {card.ExpiryDate}\n" +
                $"Card limit: {card.Limit}\n\n"
            );
        }
    }
}
