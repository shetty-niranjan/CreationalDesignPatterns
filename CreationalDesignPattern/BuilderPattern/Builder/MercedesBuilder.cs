namespace BuilderPattern.Builder
{
    internal class MercedesBuilder : CarBuilder
    {
        public override CarBuilder SetKM()
        {
            car.KM = 100;
            return this;
        }

        public override CarBuilder SetBrand()
        {
            car.Brand = "Mercedes";
            return this;
        }

        public override CarBuilder SetModel()
        {
            car.Model = "mrc";
            return this;
        }
    }
}
