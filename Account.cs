namespace bank_assignment_Tony_Aex
{
    abstract class Account
    {
        public static System.Collections.Generic.List<Person> holders;
        private int lastNumber;

        public double Balance { get; protected set; }
        public string Number { get; private set; }
        public double StartingBalance { get; protected set; }
        public System.Collections.Generic.List<Transaction> Transactions { get; protected set; }

        public Account(string typeOfAccount, double startingBalance)
        {
            this.Balance = startingBalance;
            this.StartingBalance = startingBalance;
            System.Collections.Generic.List<Transaction> Transactions = new System.Collections.Generic.List<Transaction>();
            this.Number = typeOfAccount;
            this.lastNumber = System.Convert.ToInt32(typeOfAccount);
            lastNumber++;
        }

        public void AddUser(Person person)
        {
            holders.Add(person);
        }

        public void Deposit(double amount, Person person)
        {
            Balance += amount;

        }

        public bool IsHolder(string name)
        {
            return;
        }

         public abstract void PrepareMonthlyReport()
        {
            return;
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
