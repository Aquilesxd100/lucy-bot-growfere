using bot_lucy_growfere.modelos.api;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace bot_lucy_growfere.requisicoes
{
    static class MyMemoryAPI
    {
        static private string APIUrl = "https://api.mymemory.translated.net/";

        static public async Task<string> TraduzirENparaPTBR (string mensagem)
        {
            try
            {
                string parametrosURL = $"get?q={mensagem}&langpair=en|pt-br";

                HttpResponseMessage resposta = await Program.HTTPclient.GetAsync(APIUrl + parametrosURL);
                HttpContent conteudoResposta = resposta.Content;
                string data = await conteudoResposta.ReadAsStringAsync();
                
                if(data != null)
                {
                    MyMemoryGETResponse resConvertida = JsonConvert.DeserializeObject<MyMemoryGETResponse>(data);
                    if(resConvertida != null)
                    {
                        string traducaoPTBR = resConvertida.responseData.translatedText;
                        return traducaoPTBR;
                    }
                }
                return null;
            } catch(Exception erro)
            {
                Console.WriteLine(erro);
                return null;
            }
        }
    }
}
