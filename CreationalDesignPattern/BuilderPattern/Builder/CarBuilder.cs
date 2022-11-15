using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    //Abstract Builder
    abstract class CarBuilder
    {
        protected Car car;
        public Car Car { get => car; }
        public CarBuilder()
            => car = new();
        public abstract CarBuilder SetBrand();
        public abstract CarBuilder SetModel();
        public abstract CarBuilder SetKM();
    }
}
