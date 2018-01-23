﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Match
{
    public class Participant
    {
        public int participantId { get; set; }
        public int teamId { get; set; }
        public int championId { get; set; }
        public int spell1Id { get; set; }
        public int spell2Id { get; set; }
        public string highestAchievedSeasonTier { get; set; }
        public ParticipantStats stats { get; set; }
        public TimeLine timeline { get; set; }
    }
}