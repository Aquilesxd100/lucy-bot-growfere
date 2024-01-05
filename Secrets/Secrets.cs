using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
namespace bot_lucy_growfere.Secrets
{
    public static class SecretsReader {
        public static string botToken { get; set; }
        public static string dataBaseUrl { get; set; }

        public static async Task GetSecrets() {
            using (StreamReader sr = new StreamReader("secretsData.json"))
            {
                string json = await sr.ReadToEndAsync();
                SecretsData data = JsonConvert.DeserializeObject<SecretsData>(json);

                botToken = data.botToken;
                dataBaseUrl = data.dataBaseUrl;
            }
        }
    }

    internal sealed class SecretsData {
        public string botToken { get; set; }
        public string dataBaseUrl { get; set; }
    }
}

