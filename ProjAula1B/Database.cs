namespace ProjAula1B
{
    internal class Database
    {
        readonly string connection = "Data Source = 127.0.0.1; Initial Catalog=DBPenalidadesAplicadas; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";

        readonly string connectionMongo = "mongodb://root:Mongo%402024%23@localhost:27017/";

        public Database()
        {

        }

        public string Path()
        {
            return connection;
        }

        public string PathMongo()
        {
            return connectionMongo;
        }
    }
}
