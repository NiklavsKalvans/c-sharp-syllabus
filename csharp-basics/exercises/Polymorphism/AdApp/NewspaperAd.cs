namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public new int Cost()
        {
            var fee = base.Cost() + (_column * _rate);
            return fee;
        }

        public override string ToString()
        {
            return $"\nNewsPaper: Cost = {Cost()}";
        }
    }
}