using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace ProjAula1B
{
    internal class FunctionDML
    {
        static Database b = new();
        SqlConnection conn = new(b.Path());
        SqlCommand cmd = new();
        public void InsertData(List<PenalidadesAplicadas> l)
        {
            foreach (var item in l)
            {
                try
                {
                    conn.Open();
                    cmd = new("INSERIR_PENALIDADE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@RAZAO_SOCIAL", SqlDbType.VarChar, 100).Value = item.RazaoSocial;
                    cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar, 20).Value = item.CNPJ;
                    cmd.Parameters.Add("@NOME_MOTORISTA", SqlDbType.VarChar, 50).Value = item.NomeMotorista;
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 20).Value = item.CPF;
                    cmd.Parameters.Add("@VIGENCIA_CADASTRO", SqlDbType.Date).Value = item.VigenciaCadastro;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Source.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
