using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ProjAula1B
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData()
        {
            StreamReader sr = new(@"C:\Users\adm\Documents\LINQ\motoristas_habilitados.json");
            string jsonString = sr.ReadToEnd();

            var lst = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if(lst != null) return lst.p;
            return null;
        }
    }
}
