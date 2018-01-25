using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Profile_Icon
{
    public class ProfileIcons
    {
        public static string Uri = "static-data/v3/profile-icons";

        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, ProfileIcon> data { get; set; }

        public static ProfileIcons GetAsync()
        {
            return (ProfileIcons)HttpExecute.Execute<ProfileIcons>(Uri).Result;
        }
    }
}
