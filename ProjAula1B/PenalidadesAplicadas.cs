using Newtonsoft.Json;

namespace ProjAula1B
{
    public class PenalidadesAplicadas
    {
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }

        [JsonProperty("nome_motorista")]
        public string NomeMotorista { get; set; }

        [JsonProperty("cpf")]
        public string CPF { get; set; }

        [JsonProperty("vigencia_do_cadastro")]
        public DateTime VigenciaCadastro { get; set; }

        public override string ToString() => $"Razao Social: {RazaoSocial}, CNPJ: {CNPJ}, Nome: {NomeMotorista}, CPF: {CPF}, Vigencia: {VigenciaCadastro}";
    }
}
