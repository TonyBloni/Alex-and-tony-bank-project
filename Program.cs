namespace bank_assignment_Tony_Aex
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount c = new CheckingAccount();
            VisaAccount v = new VisaAccount(500);
            SavingAccount s = new SavingAccount();

            Person narendra = new Person("Narendra", "123");
            Person bhim = new Person("Bhim", "234");
            Person mohammed = new Person("Mohammed", "345");
            Person ilia = new Person("Ilia", "456");
            Person patrick = new Person("Patrick", "567");
            Bank.Add(narendra);
            Bank.Add(bhim);
            Bank.Add(mohammed);
            Bank.Add(ilia);
            Bank.Add(patrick);

            Bank.Add(c);
            Bank.Add(v);
            Bank.Add(s);

            s.AddUser(narendra);
            v.AddUser(narendra);
            v.AddUser(ilia);
            c.AddUser(narendra);
            narendra.Login("Narendra");
            s.Deposit(500, narendra);
            c.Deposit(125, narendra);
            s.WithDraw(500, narendra);
            v.DoPurchase(12.50, narendra);
            v.DoPurchase(250, narendra);
            v.DoPurchase(12.50, narendra);

            c = new CheckingAccount(500);
            c.AddUser(mohammed);
            c.AddUser(patrick);
            Bank.Add(c);

            c = new CheckingAccount(1000);
            v = new VisaAccount(10);
            Bank.Add(c);
            Bank.Add(v);
            bhim.Login("Bhim");
            c.AddUser(bhim);
            v.AddUser(bhim);
            c.Deposit(50, bhim);
            c.Deposit(25, bhim);
            c.WithDraw(50, bhim);
            v.DoPurchase(1.50, bhim);
            v.DoPurchase(30, bhim);
            v.DoPurchase(4.50, bhim);


        }
    }
}
