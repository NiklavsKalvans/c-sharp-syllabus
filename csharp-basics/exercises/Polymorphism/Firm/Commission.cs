
namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _comRate;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double comRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _comRate = comRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + (_totalSales * _comRate);
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}
