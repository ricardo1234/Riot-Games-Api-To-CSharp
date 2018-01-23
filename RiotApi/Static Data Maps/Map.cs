using RiotApi.Static_Data_Champs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Maps
{
    public class Map
    {
        public string mapName { get; set; }
        public int mapId { get; set; }
        public Image image { get; set; }
    }
}
