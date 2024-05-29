namespace ProjAula1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var lst = ReadFile.GetData();

            //new FunctionDML().InsertData(lst);
            new FunctionMongo().ProcessDataToMongoDB();

            //Console.WriteLine("Listar registros que tenham o numero do CPF iniciando com 237");
            //PrintData(TestFilter.FilterByCPF(lst));
            //Console.WriteLine();

            //Console.WriteLine("Listar registros que tenham o ano de vigencia igual a 2021");
            //PrintData(TestFilter.FilterByYear(lst));
            //Console.WriteLine();

            //Console.WriteLine("Quantas empresas tem na razao social a palavra LTDA");
            //PrintData(TestFilter.FilterByLTDA(lst));
            //Console.WriteLine();

            //Console.WriteLine("Ordenar a lista de registros pela razao social");
            //PrintData(TestFilter.FilterOrderBySocialReason(lst));

            //Console.WriteLine("Gerar XML");
            //Console.WriteLine(TestFilter.GenerateXML(lst));

            static void PrintData(List<PenalidadesAplicadas> l)
            {
                foreach (var item in l)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
