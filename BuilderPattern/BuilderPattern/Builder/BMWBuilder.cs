namespace BuilderPattern.Builder
{
    internal class BMWBuilder : CarBuilder
    {
        public override CarBuilder SetKM()
        {
            car.KM = 50;
            return this;
        }

        public override CarBuilder SetBrand()
        {
            car.Brand = "BMW";
            return this;
        }

        public override CarBuilder SetModel()
        {
            car.Model = "bmw";
            return this;
        }
    }
}
