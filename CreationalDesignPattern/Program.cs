using BuilderPattern.Builder;
using BuilderPattern.Director;
using BuilderPattern.Product;
using CreationalDesignPattern.Abstract_Factory;
using CreationalDesignPattern.Factory;
using CreationalDesignPattern.Factory.Interface;
using CreationalDesignPattern.Prototype;
using CreationalDesignPattern.Singleton;

Console.WriteLine("------ start builder -----");
CarDirector director = new();
Car opel = director.Build(new OpelBuilder());
opel.ToString();
Car mercedes = director.Build(new MercedesBuilder());
mercedes.ToString();
Car bmw = director.Build(new BMWBuilder());
bmw.ToString();
Console.WriteLine("------ end ------");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("------ start singleton ----------");

SingletonClass singleton1 = SingletonClass.GetInstance();
int firstInstance = singleton1.GetInstanceCount();

SingletonClass singleton2 = SingletonClass.GetInstance();
int secondInstance = singleton2.GetInstanceCount();

Console.WriteLine($"Count for both instance = {firstInstance},{secondInstance}");

Console.WriteLine("------- end -------");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("------ start Prototype -------");
Person person1 = new("Niranjan", "S", Department.A, 1000, 200);

Person? person2 = person1.Clone() as Person;
person2.Name = "Rakesh";
person2.Salary = 500;
person2.ToString();

Person? person3 = person1.Clone() as Person;
person3.Name = "Sam";
person3.Salary = 100;
person3.ToString();

Console.WriteLine("------- end -------");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("------ start factory -------");

ShapeFactory shapeFactory = new();
List<IShape> shapes = new()
{
   shapeFactory.Create(ShapeType.Circle),
   shapeFactory.Create(ShapeType.Square),
   shapeFactory.Create(ShapeType.Rectangle)
};

foreach (IShape s in shapes)
    s.Draw();

Console.WriteLine("------- end -------");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("------ start abstract factory -------");
DatabaseCreator creator = new();
Database oracleDb = creator.Create(new OracleDatabaseFactory());
Database msSqlDb = creator.Create(new MSSqlDatabaseFactory());

oracleDb.Connection.Connect();
msSqlDb.Connection.Connect();

Console.WriteLine("------- end -------");
Console.WriteLine("");
Console.WriteLine("");
