using CreationalDesignPattern.Factory.Interface;

namespace CreationalDesignPattern.Factory
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle shape called..");
        }
    }
}
