using System.Collections.Generic;

namespace RiotApi.Status
{
    public class Message
    {
        #region Attributes/Properties

        public string severity { get; set; }
        public string author { get; set; }
        public string created_at { get; set; }
        public List<Translation> translations { get; set; }
        public string updated_at { get; set; }
        public string content { get; set; }
        public string id { get; set; }

        #endregion
    }
}
