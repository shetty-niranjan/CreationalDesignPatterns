namespace BuilderPattern.Builder
{
    //Concrete Builder
    internal class OpelBuilder : CarBuilder
    {
        public override CarBuilder SetKM()
        {
            car.KM = 10;
            return this;
        }

        public override CarBuilder SetBrand()
        {
            car.Brand = "Opel";
            return this;
        }

        public override CarBuilder SetModel()
        {
            car.Model = "opl";
            return this;
        }
    }
}
