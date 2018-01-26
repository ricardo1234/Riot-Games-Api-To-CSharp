namespace RiotApi
{
    public static class StaticData
    {
        #region Common
        private static string version = "v3";
        public static string APIKey = "RGAPI-c31b1efc-488d-4305-b6fd-f2190e94e6ee";
        public static string BaseUrl = "https://euw1.api.riotgames.com/lol/";
        #endregion

        #region Champion
        public static string Champion_Uri = $"platform/{version}/champions";
        #endregion

        #region Champion Mastery
        public static string ChampionMastery_Uri = $"champion-mastery/{version}/champion-masteries/by-summoner";
        public static string ChampionMastery_UriByChamp = $"/by-champion";
        public static string ChampionMastery_ScoreUri = $"champion-mastery/{version}/scores/by-summoner";
        #endregion

        #region League
        public static string League_SummonerUri = $"league/{version}/positions/by-summoner";
        public static string League_UriChallenger = $"league/{version}/challengerleagues/by-queue";
        public static string League_UriMaster = $"league/{version}/masterleagues/by-queue";
        public static string League_Uri = $"league/{version}/leagues";
        #endregion

        #region Summoner
        public static string Summoner_Uri = $"summoner/{version}/summoners/";

        #endregion

        #region Language to String
        public static string LanguageToStringUri = $"static-data/{version}/language-strings/";
        #endregion

        #region Status
        public static string Status_Uri = $"/status/{version}/shard-data";
        #endregion

        #region Spectator
        public static string Spectator_Uri = $"spectator/{version}/active-games/by-summoner/";
        #endregion

        #region Match
        public static string MatchList_Uri = $"match/{version}/matchlists/by-account/";


        #endregion
    }
}

