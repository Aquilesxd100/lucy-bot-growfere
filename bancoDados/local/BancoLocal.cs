﻿using bot_lucy_growfere.modelos.jogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot_lucy_growfere.database.local
{
    public static class BancoLocal
    {
        public static string usernameMarcelo = "marcelogrowdev";
        public static string usernameFernando = "aquiles_xd";
        public static string usernameLucas = "lucasdossantos0330";

        public static bool LucyRecebendoMarcelo = false;

        public static JogoDaVelha JogoDaVelha = new JogoDaVelha();

        public static Adivinhacao JogoAdivinhacao = new Adivinhacao();

        public static DateTime dataInicioEmpregoRefere =  new DateTime(2023, 8, 8);

        public static string codAudioReceberMarcelo = "0a84a499-89fb-41d6-b9c3-556e0468b483_Audio_Receber_Marcelo_5bc76888-b55b-43d9-b681-88a3780ab19c";
    }
}

// Servidores Lavalink
// eu-lavalink.lexnet.cc / "lexn3tl@val!nk"
// oce-lavalink.lexnet.cc // "lexn3tl@val!nk"
// lava.dcmusic.ca // "youshallnotpass"
// lavalink.lexnet.cc // "lexn3tl@val!nk"
// lavalink.teramont.net // "eHKuFcz67k4lBS64"