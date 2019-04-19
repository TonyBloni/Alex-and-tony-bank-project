namespace bank_assignment_Tony_Aex
{
    class Transaction
    {
        
        public string AccountNumber { get; set; }       
        public string Amount { get; set; }
        public double EndBalance { get; set; }
        public Person Person { get; set; }
        public System.DateTime Time { get; set; }

        public override string ToString()
        {
            return "Time: " + Time +
                   "Amount: " + Amount +
                   "User name: " + Person;

        }

    }
}
