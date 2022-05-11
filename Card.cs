namespace my_banker;

internal abstract class Card : ICard {
    private string ownerName;
    public string OwnerName {
        get => ownerName;
    }

    private string type;
    public string Type {
        get => type;
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

    private bool overCharge;
    public bool OverCharge {
        get => overCharge;
    }

    internal Card(string ownerName, string type, DateTime expiryDate, int limit, bool overCharge) {
        this.ownerName = ownerName;
        this.type = type;
        this.accNumber = GenerateAccNum();
        this.cardNumber = GenerateCardNum();
        this.expiryDate = expiryDate;
        this.limit = limit;
        this.overCharge = overCharge;
    }

    // Generates a account number
    protected string GenerateAccNum() {
        string accNumber = "3520";

        // Adds onto the banks prefix, until it hits 14
        while(accNumber.Length < 14) {
            accNumber += Random.Shared.Next(0, 10).ToString();
        }

        return accNumber;
    }

    public virtual string GenerateCardNum() {
        return "No card value found";
    }
}

