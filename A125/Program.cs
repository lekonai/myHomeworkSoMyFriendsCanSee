namespace A125;

class Program
{
    static void Main(string[] args)
    {
        List<Account> accounts = new List<Account>();
        accounts.Add(new Account(1000));
        accounts.Add(new FixedAccount(1000, 100));
        for (int i = 0; i < 10; i++)
        {
            foreach (var j in accounts)
            {
                j.MakeWithdrawal(110);
                Console.WriteLine(j.GetBalance());
            }
        }
    }
}