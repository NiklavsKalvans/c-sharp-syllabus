namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double balace)
        {
            _name = name;
            _money = balace;
        }

        public double Withdrawal(double i)
        {
            return _money -= i;
        }

        public void Deposit(double i)
        {
            _money += i;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
