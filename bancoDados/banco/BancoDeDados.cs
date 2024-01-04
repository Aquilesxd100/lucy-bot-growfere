using MySql.Data.MySqlClient;
using System.Data;
using System;
using bot_lucy_growfere.models.bancoDados;

namespace bot_lucy_growfere.database.banco
{
    public class BancoDeDados
    {
        private static string connStr = Environment.GetEnvironmentVariable("BANCO_URL");
        public static MySqlConnection conexao = new MySqlConnection(connStr);

        static public void VerificarConexao()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao abrir a conexão: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static void ExecuteSql(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = cmd.ExecuteReader();
            leitor.Close();
        }

        public static string GetHoraUltimaMensagemMandada()
        {
            VerificarConexao();
            Console.WriteLine("Connecting to MySQL to get ultimaVezMensagemMandada...");
            string sql = "SELECT * FROM BotDiscord";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = cmd.ExecuteReader();

            BotDiscordModelo botDiscord = new BotDiscordModelo();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    botDiscord.ultimaVezMensagemMandada = leitor["ultimaVezMensagemMandada"].ToString();
                }
            }

            leitor.Close();
            return botDiscord.ultimaVezMensagemMandada ?? null;
        }

        public static void AtualizarUltimaVezMarceloFoiRecebido(DateTime dataAtual)
        {
            VerificarConexao();
            string dataAtualSTRING = dataAtual.ToString();
            string sql = $"UPDATE BotDiscord SET ultimaVezMensagemMandada = '{dataAtualSTRING}'";
            ExecuteSql(sql);
        }
    }
}