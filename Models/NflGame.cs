using System;

namespace NFLPredictions.Models
{
    public class NflGame
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string AwayTeam { get; set; } = string.Empty;

        public string HomeTeam { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}