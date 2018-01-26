using Newtonsoft.Json;

namespace RiotApi.Static_API.Static_Data_Champs.Static_Data_Items
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
