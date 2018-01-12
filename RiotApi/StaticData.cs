using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public static class StaticData
    {
        public static string APIKey = "?api_key=RGAPI-1f8f3ded-8df9-4b53-bf4f-c538540d2276";
        public static string BaseUrl = "https://euw1.api.riotgames.com/lol/";
    }
    public enum RequestType
    {
        ById,
        ByName,
        ByAccount
    }
    public enum Plataform
    {
        EUW1,
        EUN1
    }
    public enum GameType
    {
        MATCHED_GAME
    }
    public enum GameMode
    {
        CLASSIC
    }
}

