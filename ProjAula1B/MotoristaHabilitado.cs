using Newtonsoft.Json;

namespace ProjAula1B
{
    internal class MotoristaHabilitado
    {
        [JsonProperty("penalidades_aplicadas")]
        public List<PenalidadesAplicadas> p { get; set; }
    }
}
