using System.Collections.Generic;

namespace RiotApi.Status
{
    public class Incident
    {
        #region Attributes/Properties

        public long id { get; set; }
        public bool active { get; set; }
        public string created_at { get; set; }
        public List<Message> updates { get; set; }

        #endregion
    }
}
