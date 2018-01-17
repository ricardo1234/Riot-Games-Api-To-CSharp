using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Champs
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
