using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.Status
{
    public class Status
    {
        #region Attributes/Properties

        public string name { get; set; }
        public string slug { get; set; }
        public string hostname { get; set; }
        public string region_tag { get; set; }
        public List<string> locales { get; set; }
        public List<Service> services { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get the Status of the Game: Bugs, System Fails.....
        /// </summary>
        /// <returns>Status</returns>
        public static Status GetAsync() => (Status)HttpExecute.Execute<Status>($"{StaticData.Status_Uri}").Result;

        #endregion
    }
}
