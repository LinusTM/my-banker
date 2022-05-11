namespace my_banker;

internal abstract class Card : ICard {
    private string ownerName;
    public string OwnerName {
        get => ownerName;
    }

    private string accNumber;
    public string AccNumber {
        get => accNumber;
    }

    protected string cardNumber;
    public string CardNumber {
        get => cardNumber;
    }

    private int limit;
    public int Limit {
        get => limit;
    }

    private DateTime expiryDate;
    public DateTime ExpiryDate {
        get => expiryDate;
    }

    internal Card(string ownerName, DateTime expiryDate, int limit) {
        this.accNumber = GenerateAccNum();
        this.cardNumber = GenerateCardNum();
        this.ownerName = ownerName;
        this.expiryDate = expiryDate;
        this.limit = limit;
    }

    protected string GenerateAccNum() {
        string accNumber = "3520";

        while(accNumber.Length < 14) {
            accNumber += Random.Shared.Next(0, 10).ToString();
        }

        return accNumber;
    }

    public virtual string GenerateCardNum() {
        return "No card value found";
    }
}

