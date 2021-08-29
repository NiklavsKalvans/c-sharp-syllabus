
namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string _region;
        public Mammal(string type, string name, double weight, string region) : base(type, name, weight)
        {
            _region = region;
        }
    }
}
