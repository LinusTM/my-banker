namespace my_banker;

interface ICard {
    string OwnerName { get; }
    string AccNumber { get; }
    string CardNumber { get; }
    int Limit { get; }
    DateTime ExpiryDate { get; }

    // int Deposit(int money);
    // int Withdraw (int money);
    string GenerateCardNum();
}
