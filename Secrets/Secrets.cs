using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
namespace bot_lucy_growfere.Secrets
{
    public class SecretsReader {
        public string botToken { get; set; }
        public string dataBaseUrl { get; set; }

        public async Task GetSecrets() {
            using (StreamReader sr = new StreamReader("secretsData.json"))
            {
                string json = await sr.ReadToEndAsync();
                SecretsData data = JsonConvert.DeserializeObject<SecretsData>(json);

                this.botToken = data.botToken;
                this.dataBaseUrl = data.dataBaseUrl;
            }
        }
    }

    internal sealed class SecretsData {
        public string botToken { get; set; }
        public string dataBaseUrl { get; set; }
    }
}

