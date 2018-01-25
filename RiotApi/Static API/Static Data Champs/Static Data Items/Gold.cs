using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace RiotApi.Static_Data_Champs.Static_Data_Items
{
    public class Gold
    {
        public int sell { get; set; }
        public int total { get; set; }
        [JsonProperty("base")]
        public int @base { get; set; }
        public bool purchasable { get; set; }
    }
}
