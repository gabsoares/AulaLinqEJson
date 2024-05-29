using System;
using System.Xml.Linq;

namespace ProjAula1B
{
    internal class TestFilter
    {
        public static int GetCountRecords(List<PenalidadesAplicadas> l) => l.Count;
        public static List<PenalidadesAplicadas> FilterByCPF(List<PenalidadesAplicadas> l) => l.Where(l => l.CPF.Substring(0, 3) == "237").ToList();

        public static List<PenalidadesAplicadas> FilterByYear(List<PenalidadesAplicadas> l) => l.Where(l => l.VigenciaCadastro.Year == 2021).ToList();

        public static List<PenalidadesAplicadas> FilterByLTDA(List<PenalidadesAplicadas> l) => l.Where(l => l.RazaoSocial.Contains("LTDA")).ToList();

        public static List<PenalidadesAplicadas> FilterOrderBySocialReason(List<PenalidadesAplicadas> l) => l.OrderBy(l => l.RazaoSocial).ToList();

        public static string GenerateXML(List<PenalidadesAplicadas> l)
        {
            if (l.Count > 0)
            {
                var penalidadeAplicada = new XElement("Root", from data in l
                                                              select new XElement("motorista",
                                                              new XElement("razao_social", data.RazaoSocial),
                                                              new XElement("cnpj", data.CNPJ),
                                                              new XElement("nome_motorista", data.NomeMotorista),
                                                              new XElement("cpf", data.CPF),
                                                              new XElement("vigencia_do_cadastro", data.VigenciaCadastro)
                                                                )
                                                              );
                return penalidadeAplicada.ToString();
            }
            else
            {
                return "Nao existem registros.";
            }
        }
    }
}
