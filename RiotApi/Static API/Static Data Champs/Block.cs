using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Champs
{
    public class Block
    {
        public string type { get; set; }
        public bool recMath { get; set; }
        public List<Item> items { get; set; }
    }
}
