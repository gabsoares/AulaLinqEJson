using System.Numerics;
using System.Xml.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var people = Adm.LoadData();
            Adm.PrintData(people);
            Console.WriteLine();

            Console.WriteLine("Listar todas as pessoas que tem mais de 18 anos.");
            Adm.PrintData(Adm.FilterByAgeUseLinq(people));
            Console.WriteLine();

            Console.WriteLine("Listar todas as pessoas que tenham o nome que inicia com a letra a");
            Adm.PrintData(Adm.FilterByNameUseLinq(people));
            Console.WriteLine();

            Console.WriteLine("Listar todas as pessoas e ordenar por nome");
            Adm.PrintData(Adm.OrderByNameUseLinq(people));
            Console.WriteLine();

            Console.WriteLine("Listar todas as pessoas e ordenar por nome descrescente");
            Adm.PrintData(Adm.OrderByNameDescendingUseLinq(people));
            Console.WriteLine();

            Console.WriteLine("Listar todas as pessoas que tem a letra a no nome e o nome tem que ter mais de 3 caracteres");
            Adm.PrintData(Adm.FilterByNameAndLengthUseLinq(people));
        }
    }
}
