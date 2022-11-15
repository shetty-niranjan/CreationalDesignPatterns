using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    internal class CarDirector
    {
        public Car Build(CarBuilder carBuilder)
        {
            carBuilder.SetBrand()
                .SetModel()
                .SetKM();
            return carBuilder.Car;
        }
    }
}
