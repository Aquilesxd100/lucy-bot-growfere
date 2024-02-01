using bot_lucy_growfere.modelos.api;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace bot_lucy_growfere.requisicoes
{
    static class BrasilAPI
    {
        static private string APIUrl = "https://brasilapi.com.br/";

        static public async Task<BrasilAPIFeriadoPorAno[]> ListarFeriadosDeUmAno (int ano)
        {
            try
            {
                string parametrosURL = $"api/feriados/v1/{ano}";

                HttpResponseMessage resposta = await Program.HTTPclient.GetAsync(APIUrl + parametrosURL);
                HttpContent conteudoResposta = resposta.Content;

                string data = await conteudoResposta.ReadAsStringAsync();
                if(data != null)
                {
                    BrasilAPIFeriadoPorAno[] resConvertida = JsonConvert.DeserializeObject<BrasilAPIFeriadoPorAno[]>(data);
                    if(resConvertida.Length > 0)
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
