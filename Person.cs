namespace bank_assignment_Tony_Aex
{
    class Person
    {
        public bool IsAuthenticated { get; private set; }     
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string SIN { get; private set; }

        public void Login(string password)
        {
            if (password == Password)
                IsAuthenticated = true;
        }

        public void Logout()
        {
            IsAuthenticated = false;
        }

        public Person(string name, string sin)
        {
            this.Name = name;
            this.SIN = sin;
            name = Password;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
