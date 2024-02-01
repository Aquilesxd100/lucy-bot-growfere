using bot_lucy_growfere.modelos.api;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace bot_lucy_growfere.requisicoes
{
    static class RandomUserAPI
    {
        static private string APIUrl = "https://randomuser.me/";

        static public async Task<RandomUserGETResponse> GerarUsuarioAleatorio ()
        {
            try
            {
                string parametrosURL = "api";
                HttpResponseMessage resposta = await Program.HTTPclient.GetAsync(APIUrl + parametrosURL);
                HttpContent conteudoResposta = resposta.Content;

                string data = await conteudoResposta.ReadAsStringAsync();

                if (data != null)
                {
                    RandomUserGETResponse resConvertida = JsonConvert.DeserializeObject<RandomUserGETResponse>(data);
                    if(resConvertida != null)
                    {
                        return resConvertida;
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
