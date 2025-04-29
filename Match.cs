using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilt
{
    class Metadata
    {
        public string dataVersion { get; set; }
        public string matchId { get; set; }

        public List<string> participants { get; set; }
    }

    class Info
    {
        public string endOfGameResult { get; set; }
        public long gameCreation { get; set; }
        public int gameDuration { get; set; }
        public long gameEndTimestamp { get; set; }
        public long gameId { get; set; }
        public string gameName { get; set; }
        public long gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public string tournamentCode { get; set; }
        public int queueId { get; set; }


        public List<Team> teams { get; set; }
        public List<Participant> participants { get; set; }


        public string gameMode { get; set; }
        public string platformId { get; set; }

    }

    class Participant
    {
        public int PlayerScore0 { get; set; }
        public int PlayerScore1 { get; set; }
        public int PlayerScore10 { get; set; }
        public int PlayerScore11 { get; set; }
        public int PlayerScore2 { get; set; }
        public int PlayerScore3 { get; set; }
        public int PlayerScore4 { get; set; }
        public int PlayerScore5 { get; set; }
        public int PlayerScore6 { get; set; }
        public int PlayerScore7 { get; set; }
        public int PlayerScore8 { get; set; }
        public int PlayerScore9 { get; set; }


        public int allInPings { get; set; }
        public int assistMePings { get; set; }
        public int assists { get; set; }
        public int baronKills { get; set; }
        public int basicPings { get; set; }
        public int bountyLevel { get; set; }

        public string role { get; set; }
        public string puuid { get; set; }
        public string riotIdGameName { get; set; }
        public string riotIdTagline { get; set; }

        public string championName { get; set; }

        public int teamId { get; set; }

        public int totalDamageDealtToChampions { get; set; }

        public int kills { get; set; }
        public int deaths { get; set; }

        public bool win { get; set; }
    }

    class Team
    {
        public int teamId { get; set; }
        public bool win { get; set; }
    }


    internal class Match
    {

        public Metadata metadata {  get; set; }
        public Info info { get; set; }

        public int FindPlayerIndex(string puuid)
        {
            List<Participant> PlayerList = this.info.participants;//reference

            for (int i = 0; i < PlayerList.Count; i++)
            {
                if (PlayerList[i].puuid == puuid)
                {
                    return i;

                }
            }

            return -1;
        }
    }
}
