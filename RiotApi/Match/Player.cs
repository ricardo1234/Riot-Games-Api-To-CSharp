using RiotApi.Emuns;

namespace RiotApi.Match
{
    public class Player
    {
        public Platform platformId { get; set; }
        public int accountId { get; set; }
        public string summonerName { get; set; }
        public int summonerId { get; set; }
        public Platform currentPlatformId { get; set; }
        public int currentAccountId { get; set; }
        public string matchHistoryUri { get; set; }
        public int profileIcon { get; set; }
    }
}
