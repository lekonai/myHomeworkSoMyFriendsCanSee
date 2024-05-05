namespace A125;

public class Account
{
    protected int balance;

    public Account(int startBalance )
    {
        balance = startBalance;
    }
    public int GetBalance()
    {
        return balance;
    }
    public void MakeDeposit(int amount)
    {
        balance += amount;
    }
    public virtual void MakeWithdrawal(int amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
    }
}

public class FixedAccount : Account
{
    private int withdrawalFee;
    public FixedAccount(int sBal, int fee): base(sBal)
    {
        withdrawalFee = fee;
    }
    public override void MakeWithdrawal(int amount)
    {
        base.MakeWithdrawal(amount);
        if (balance != 0)
        {
            if (balance - withdrawalFee >= 0)
            {
                balance -= withdrawalFee; // oh i can't take okay i need to change it back to an int
            }
            else
            {
                balance = 0;
            }
        }
    }
}