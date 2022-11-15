using CreationalDesignPattern.Factory.Interface;

namespace CreationalDesignPattern.Factory
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square shape called..");
        }
    }
}
