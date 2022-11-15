using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Factory.Interface;

namespace CreationalDesignPattern.Factory
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle shape called..");
        }
    }
}
