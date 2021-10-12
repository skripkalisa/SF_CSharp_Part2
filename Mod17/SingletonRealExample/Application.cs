namespace SingletonRealExample
{
    public class Application
    {
        public DbConnection DbConnection { get; set; }
        public void Launch(string dbServer)
        {
            DbConnection = DbConnection.GetConnectionInstance(dbServer);
        }
    }
}