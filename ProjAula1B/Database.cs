namespace ProjAula1B
{
    internal class Database
    {
        readonly string connection = "Data Source = 127.0.0.1; Initial Catalog=DBPenalidadesAplicadas; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";

        public Database()
        {

        }

        public string Path()
        {
            return connection;
        }
    }
}
