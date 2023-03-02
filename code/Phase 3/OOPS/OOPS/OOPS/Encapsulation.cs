namespace OOPS
{
    public class Encapsulation
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank("Dhruvil Dobariya");

            Console.WriteLine(bank.Name);
            bank.Name = "Dhruvil A. Dobariya";
            Console.WriteLine(bank.Name);

            Console.WriteLine(bank.DisplayBalance());
            bank.AddBalance(1000.00);
            Console.WriteLine(bank.DisplayBalance());

            bank.WithdrowMoney(500);
            bank.WithdrowMoney(1000);
        }
    }
    public class Bank
    {
        public string Name { get; set; } = string.Empty;
        private double Balance { get; set; }

        public Bank(string name)
        {
            Name = name;
            Balance = 0;
        }

        public double DisplayBalance()
        {
            return Balance;
        }
        public void AddBalance(double balance)
        {
            Balance += balance;
        }
        public void WithdrowMoney(double money)
        {
            if ((Balance - money) >= 0)
            {
                Balance -= money;
                Console.WriteLine($"{money} withdrow successfully and your remaining balance is {Balance}");
            }
            else
            {
                Console.WriteLine($"You can't withdrow {money}, because you have only {Balance} balance");
            }
        }
    }
}
