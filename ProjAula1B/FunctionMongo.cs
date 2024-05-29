using Microsoft.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Data;

namespace ProjAula1B
{
    internal class FunctionMongo
    {
        static Database bMongo = new();
        private readonly IMongoCollection<BsonDocument> _multasCollection;

        static Database bSql = new();
        SqlConnection conn = new(bSql.Path());
        SqlCommand cmd = new();

        public FunctionMongo()
        {
            var client = new MongoClient(bMongo.PathMongo());
            var database = client.GetDatabase("PenalidadesAplicadas");
            _multasCollection = database.GetCollection<BsonDocument>("Multas");
        }

        public void ProcessDataToMongoDB()
        {
            string razaoSocial = "";
            string cnpj = "";
            string nomeMotorista = "";
            string cpf = "";
            DateTime vigenciaCadastro;
            int cont = 1;
            Console.WriteLine("Inserindo registros no mongo...");
            try
            {
                conn.Open();
                cmd = new();
                cmd.CommandText = "SELECT * FROM PENALIDADES_APLICADAS";
                cmd.Connection = conn;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        razaoSocial = reader.GetString(1);
                        cnpj = reader.GetString(2);
                        nomeMotorista = reader.GetString(3);
                        cpf = reader.GetString(4);
                        vigenciaCadastro = reader.GetDateTime(5);

                        var document = new BsonDocument
                        {
                            { "_id", cont },
                            { "RazaoSocial", razaoSocial },
                            { "CNPJ", cnpj },
                            { "NomeMotorista", nomeMotorista },
                            { "CPF", cpf },
                            { "VigenciaCadastro", vigenciaCadastro.ToString("dd/MM/YYYY") }
                        };
                        _multasCollection.InsertOne(document);
                        cont++;
                    }
                    Console.WriteLine("Registros inseridos com sucesso.");
                }
                cmd = new("INSERIR_CONTROLE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar, 100).Value = "LOG DE REGISTROS BANCO DE DADOS";
                cmd.Parameters.Add("@DATA_CONTROLE", SqlDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("@NUMERO_REGISTROS", SqlDbType.Int).Value = cont - 1;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tabela de Controle de Processamento do SQL atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Source.ToString());
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
