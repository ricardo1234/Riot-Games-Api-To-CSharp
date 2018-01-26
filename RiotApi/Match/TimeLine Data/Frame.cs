using System.Collections.Generic;

namespace RiotApi.Match.TimeLine_Data
{
    public class Frame
    {
        public long timestamp { get; set; }
        public Dictionary<string,ParticipantFrame> participantFrames { get; set; }
    }

    /*
     "type": "CHAMPION_KILL",
"timestamp": 55461,
"position": {
"x": 13377,
"y": 2478
},
"killerId": 9,
"victimId": 5,
"assistingParticipantIds": [
6,
8
]
*****************************
"type": "WARD_PLACED",
"timestamp": 46650,
"wardType": "YELLOW_TRINKET",
"creatorId": 3
********************************
"type": "BUILDING_KILL",
"timestamp": 1000545,
"position": {
"x": 6919,
"y": 1483
},
"killerId": 8,
"assistingParticipantIds": [
6,
9
],
"teamId": 100,
"buildingType": "TOWER_BUILDING",
"laneType": "BOT_LANE",
"towerType": "INNER_TURRET"


     
     */
}
