using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public static class StaticData
    {
        private static string version = "v3";
        public static string APIKey = "RGAPI-8d101d13-db07-46d5-9455-31b9c2adc050";
        public static string BaseUrl = "https://euw1.api.riotgames.com/lol/";

        

        public static string LanguageToStringUri = $"static-data/{version}/language-strings/";

        public static string SummonerUri = $"summoner/{version}/summoners/";

        public static string League_SummonerUri = $"league/{version}/positions/by-summoner";
        public static string League_UriChallenger = $"league/{version}/challengerleagues/by-queue";
        public static string League_UriMaster = $"league/{version}/masterleagues/by-queue";
        public static string League_Uri = $"league/{version}/leagues";

        public static string ChampionMastery_Uri = $"champion-mastery/{version}/champion-masteries/by-summoner";
        public static string ChampionMastery_UriByChamp = $"/by-champion";
        public static string ChampionMastery_ScoreUri = $"champion-mastery/{version}/scores/by-summoner";
    }
}

