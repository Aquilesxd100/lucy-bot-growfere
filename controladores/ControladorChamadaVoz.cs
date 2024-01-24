using DSharpPlus.EventArgs;
using DSharpPlus;
using System.Threading.Tasks;
using bot_lucy_growfere.comandos;

namespace bot_lucy_growfere.controladores
{
    internal static class ControladorChamadaVoz
    {
        public static async Task DeteccaoMudancaEstadoVoz(
            DiscordClient usuarioQueAtivou,
            VoiceStateUpdateEventArgs estadoDeVoz
        )
        {

            // Se o usuario for um BOT não faz nada
            if (
                estadoDeVoz.User.IsBot
            )
            {
                return;
            }

            // Tenta receber o Marcelo se for apropriado
            await ComandosVoz.ReceberMarcelo(usuarioQueAtivou, estadoDeVoz);

        }
    }
}
