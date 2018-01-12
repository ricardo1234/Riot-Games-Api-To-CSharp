using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi;
namespace TestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               
                Console.Write("Summoner Name:");
                var summoner = Summoner.GetAsync(Console.ReadLine(), RequestType.ByName);
                if (summoner == null)
                {
                    Console.WriteLine("User Not Found");
                    continue;
                }

                Console.WriteLine();

                Console.WriteLine($"Id: {summoner.id} | AccountId: {summoner.accountId} | Level: {summoner.summonerLevel} | Name: {summoner.name} | Icon: {summoner.profileIconId}");
                Console.WriteLine();

                var spec = Spectator.GetAsync(summoner.id);
                if (spec == null)
                {
                    Console.WriteLine("Isn't in Game");
                    continue;
                }
                Console.WriteLine($"Game Id: {spec.gameId} | Start Date: {spec.gameStartTime} | Game Mode: {spec.gameMode} | Game Type: {spec.gameType} | Map Id: {spec.mapId}");
                Console.WriteLine();

                Console.WriteLine($"Participants: ");
                foreach (var item in spec.participants)
                    Console.WriteLine($"    Summoner Name: {item.summonerName} | Champion Id: {item.championId} | Is bot: {item.bot} | Spell 1: {item.spell1Id} | Spell 2: {item.spell2Id} | Team: {item.teamId}");
                Console.WriteLine("Finish Details of the Game");
                Console.WriteLine();
            }
        }
    }
}
