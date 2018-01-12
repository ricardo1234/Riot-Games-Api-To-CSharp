using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Perks
    {
        public int perkStyle { get; set; }
        public List<int> perkIds { get; set; }
        public int perkSubStyle { get; set; }
        
    }
}
