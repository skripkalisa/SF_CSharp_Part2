namespace SingletonRealExample
{
    public class DbConnection
    {
        private static DbConnection Connection;
 
        public string Configuration { get; private set; }
 
        protected DbConnection(string configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
        /// </summary>
        public static DbConnection GetConnectionInstance(string dbServer)
        {
            if (Connection == null)
                Connection = new DbConnection(dbServer);
            return Connection;
        }
    }
}