using System.Collections.Generic;

namespace RiotApi.Status
{
    public class Service
    {
        #region Attributes/Properties

        public string status { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public List<Incident> incidents { get; set; }

        #endregion
    }
}
