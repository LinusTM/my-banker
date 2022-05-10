namespace my_banker;

internal abstract class Card {
    private string ownerName;
    public string OwnerName {
        get => ownerName;
    }

    private string accNumber;
    public string AccNumber {
        get => accNumber;
    }

    private string cardNumber;
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

    private string[] idNumbers;

    internal Card(string ownerName, DateTime expiryDate, int limit, string[] idNumbers) {
        this.idNumbers = idNumbers;

        this.cardNumber = GenerateCardNumber(idNumbers);
        this.accNumber = GenerateAccNum();
        this.ownerName = ownerName;
        this.expiryDate = expiryDate;
        this.limit = limit;
    }

    protected string GenerateAccNum() {
        string accNumber = Random.Shared.Next(10000, 100000).ToString();
        return "3520" + accNumber + accNumber;
    }

    protected string GenerateCardNumber(string[] idNumber) {

        return cardNumber;
    }
}

