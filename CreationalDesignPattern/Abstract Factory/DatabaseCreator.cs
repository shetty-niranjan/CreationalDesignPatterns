using CreationalDesignPattern.Abstract_Factory.AbstractProduct;
using CreationalDesignPattern.Abstract_Factory.ConcreteProduct;

namespace CreationalDesignPattern.Abstract_Factory
{
    //Cretor
    internal class DatabaseCreator
    {
        AbstractConnection _connection;
        AbstractCommand _command;

        public Database Create(DatabaseFactory databaseFactory)
        {
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();


            return new()
            {
                Command = _command,
                Connection = _connection,
                Type = (DatabaseType)Enum.Parse(typeof(DatabaseType), databaseFactory.GetType().Name.Replace("DatabaseFactory", ""))
            };
        }
    }

   class Database
    {
        public Database() { }
        public Database(DatabaseType type, Connection connection, Command command)
        {
            Type = type;
            Connection = connection;
            Command = command;
        }

        public DatabaseType Type { get; set; }
        public AbstractConnection Connection { get; set; }
        public AbstractCommand Command { get; set; }
    }
}
