using CreationalDesignPattern.Abstract_Factory.AbstractProduct;

namespace CreationalDesignPattern.Abstract_Factory.ConcreteProduct
{
    class Connection : AbstractConnection
    {
        string _connectionString;
        public Connection() { }
        public Connection(string connectionString)
            => _connectionString = connectionString;

        public override string ConnectionString { get => _connectionString; set => _connectionString = value; }
        public override ConnectionState State { get; set; }
        public override bool Connect()
        {
            State = ConnectionState.Open;
            return true;
        }
        public override bool Disconnect()
        {
            State = ConnectionState.Close;
            return true;
        }
    }
}
