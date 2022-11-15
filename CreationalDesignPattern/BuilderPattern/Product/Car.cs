namespace BuilderPattern.Product
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{Brand} Brand car {Model} Model {KM} kilometers");
            return base.ToString();
        }
    }
}
