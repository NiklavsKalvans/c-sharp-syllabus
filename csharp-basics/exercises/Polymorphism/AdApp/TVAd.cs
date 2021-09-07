namespace AdApp
{
    public class TVAd: Advert
    {
        private int _time;
        private int _rate;
        private bool _isPrime;
        public TVAd(int fee, int time, int rate, bool isPrime) : base(fee)
        {
            _time = time;
            _rate = rate;
            _isPrime = isPrime;
        }
        
        public new int Cost() 
        {
            if (_isPrime == true)
            {
                return _time * (_rate * 2) + base.Cost();
            }
            else return _time * _rate + base.Cost();
        }

        public override string ToString() 
        {
            return $"\nTVAd: Cost = {Cost()}";
        }
    }
}