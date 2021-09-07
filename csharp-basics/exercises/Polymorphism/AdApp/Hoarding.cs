namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;

        public Hoarding(int fee, int days, int rate) : base(fee)
        {
            _numDays = days;
            _rate = rate;
        }

        public new int Cost() 
        {
            int cost = _numDays * _rate + base.Cost();
            return cost;
        }

        public override string ToString() 
        {
            return $"\nHording: Cost = {Cost()}";
        }
    }
}