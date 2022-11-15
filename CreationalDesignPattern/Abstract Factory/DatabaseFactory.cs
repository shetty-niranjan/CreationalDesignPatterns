using CreationalDesignPattern.Abstract_Factory.AbstractProduct;
using CreationalDesignPattern.Abstract_Factory.ConcreteProduct;

namespace CreationalDesignPattern.Abstract_Factory
{

    enum DatabaseType
    {
        Oracle,
        MSSql
    }
    enum ConnectionState
    {
        Open, Close
    }

     //Abstract Factory
    abstract class DatabaseFactory
    {
        public abstract AbstractConnection CreateConnection();
        public abstract AbstractCommand CreateCommand();
    }

    //Concrete Factory
    class MSSqlDatabaseFactory : DatabaseFactory
    {
        public MSSqlDatabaseFactory() { Console.WriteLine("MSSQL DB class created.."); }
        public override AbstractCommand CreateCommand()
        {
            Command command = new();
            return command;
        }

        public override AbstractConnection CreateConnection()
        {            
            Connection connection = new Connection();
            connection.ConnectionString = "MSSQL connection string";
            Console.WriteLine("MSSQL connection estabilished");
            return connection;
        }
    }

    //Concrete Factory
    class OracleDatabaseFactory : DatabaseFactory
    {
        public OracleDatabaseFactory() { Console.WriteLine("Oracle DB class created.."); }
        public override AbstractCommand CreateCommand()
        {
            Command command = new();
            return command;
        }

        public override AbstractConnection CreateConnection()
        {
            Connection connection = new Connection();
            Console.WriteLine("Oracle connection estabilished");
            connection.ConnectionString = "Oracle connection string";
            return connection;
        }
    }
}
