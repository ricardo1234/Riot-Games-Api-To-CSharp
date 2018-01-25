using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RiotApi;
using RiotApi.Emuns;
using RiotApi.League;
using RiotApi.Match;
using RiotApi.Static_Data_Champs;
using RiotApi.Static_Data_Masteries;
using RiotApi.Static_Data_Summoner;

namespace TestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Summoner Name:");
                var summoner = Summoner.GetAsync(/*Console.ReadLine()*/"Nolife Raphael", RequestType.ByName);
                
                if (summoner == null)
                {
                    Console.WriteLine("User Not Found");
                    continue;
                }
                var c = ChampionMastery.GetScoreAsync(summoner.id);
                Console.Read();
                /*
                var s = SummonerLeague.GetAsync(summoner.id);
                Console.WriteLine();

                Console.WriteLine($"Id: {summoner.id} | AccountId: {summoner.accountId} | Level: {summoner.summonerLevel} | Name: {summoner.name} | Icon: {summoner.profileIconId}");
                Console.WriteLine();
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("*************************** Get Current Match ***************************");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();

                var spec = Spectator.GetAsync(summoner.id);
                if (spec == null)
                {
                    Console.WriteLine("Isn't in Game");
                    goto Masteries;
                }

                Console.WriteLine($"Game Id: {spec.gameId} | Start Date: {spec.gameStartTime} | Game Mode: {spec.gameMode} | Game Type: {spec.gameType} | Map Id: {spec.mapId}");
                Console.WriteLine();
                Console.WriteLine($"Participants: ");

                foreach (var item in spec.participants)
                    Console.WriteLine($"    Summoner Name: {item.summonerName} | Champion Id: {item.championId} | Is bot: {item.bot} | Spell 1: {item.spell1Id} | Spell 2: {item.spell2Id} | Team: {item.teamId}");

                Console.WriteLine("Finish Details of the Game");

                Masteries: Console.Read();
                Console.WriteLine();
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("********************* Get The Masteries For champs **********************");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();

                var data = ChampionMastery.GetAsync(summoner.id.ToString(), RequestType.BySummoner);
                if (data == null)
                    continue;
                foreach (var item in data)
                {
                    string a = item.championId < 10 ? "  " : item.championId < 100 ? " " : "";
                    Console.WriteLine($"Champion: {item.championId}{a} | Level: {item.championLevel} | Chest Granted: {item.chestGranted} | Last Time Played: {item.lastPlayTime}");
                }*/

            }
        }
    }
}
