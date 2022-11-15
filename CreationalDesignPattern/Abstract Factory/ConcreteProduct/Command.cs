using CreationalDesignPattern.Abstract_Factory.AbstractProduct;

namespace CreationalDesignPattern.Abstract_Factory.ConcreteProduct
{
    class Command : AbstractCommand
    {
        public override void Execute(string query)
        {
            //...executing...
        }
    }
}
