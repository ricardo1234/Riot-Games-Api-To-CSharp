using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public static class StaticData
    {
        public static string APIKey = "?api_key=RGAPI-1d1ccae3-ab16-49b4-a164-b692d4bd1e05";
        public static string BaseUrl = "https://euw1.api.riotgames.com/lol/";
    }
    public enum RequestType
    {
        ById,
        ByName,
        ByAccount,
        BySummoner,
        ByChampAndSummoner
    }
    public enum Plataform
    {
        EUW1,
        EUN1,
        NA1,
        JP1,
        KR,
        OC1,
        BR1,
        LA1,
        LA2,
        RU,
        TR1,
        PBE1
    }
    public enum GameType
    {
        MATCHED_GAME,
        TUTORIAL_GAME,
        CUSTOM_GAME
    }
    public enum GameMode
    {
        CLASSIC,
        ODIN,
        ARAM,
        TUTORIAL,
        URF,
        DOOMBOTSTEEMO,
        ONEFORALL,
        ASCENSION,
        FIRSTBLOOD,
        KINGPORO,
        SIEGE,
        ASSASSINATE,
        ARSR,
        DARKSTAR,
        STARGUARDIAN,
        PROJECT,
        INTRO
    }
}

