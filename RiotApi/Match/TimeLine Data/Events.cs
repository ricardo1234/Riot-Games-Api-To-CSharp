using System.Collections.Generic;
using RiotApi.Emuns;

namespace RiotApi.Match.TimeLine_Data
{
    public class Events
    {
        public EventTypes type { get; set; }
        public long timestamp { get; set; }
        public int participantId { get; set; }
        public int skillSlot { get; set; }
        public string eventType { get; set; }
        public TowerType towerType { get; set; }
        public int teamId { get; set; }
        public string ascendedType { get; set; }
        public string levelUpType { get; set; }
        public string pointCaptured { get; set; }
        public List<int> assistingParticipantIds { get; set; }
        public string wardType { get; set; }
        public MonsterType monsterType { get; set; }
        public int victimId { get; set; }
        public int afterId { get; set; }
        public MonsterSubType monsterSubType { get; set; }
        public LaneType laneType { get; set; }
        public int itemId { get; set; }
        public string buildingType { get; set; }
        public int creatorId { get; set; }
        public Position position { get; set; }
        public int beforeId { get; set; }
    }
}
