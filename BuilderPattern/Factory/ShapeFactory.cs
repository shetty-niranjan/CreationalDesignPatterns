using CreationalDesignPattern.Factory.Interface;

namespace CreationalDesignPattern.Factory
{
    #region Creator
    public enum ShapeType
    {
        Circle, Square, Rectangle
    }

    public interface IShapeFactory
    {
       public IShape Create(ShapeType shapeType);
    }
    public class ShapeFactory : IShapeFactory
    {
        public IShape Create(ShapeType shapeType)
        {
            IShape _shapeFactory = shapeType switch
            {
                ShapeType.Circle => new Circle(),
                ShapeType.Square => new Square(),
                ShapeType.Rectangle => new Rectangle(),
                _ => throw new NotImplementedException()
            };

            return _shapeFactory;
        }
    }
    #endregion
}
