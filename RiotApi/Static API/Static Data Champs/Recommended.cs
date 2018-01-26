using System.Collections.Generic;
using RiotApi.Emuns;

namespace RiotApi.Static_API.Static_Data_Champs
{
    public class Recommended
    {
        public string Champion { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string map { get; set; }
        public GameMode mode { get; set; }
        public List<Block> blocks { get; set; }
    }
}
