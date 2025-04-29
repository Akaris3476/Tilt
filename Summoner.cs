using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tilt
{
    internal class Summoner
    {
        public class Account
        {

            public string puuid { get; set; }
            public string gameName { get; set; }
            public string tagLine { get; set; }

            public string Nickname { get => gameName; }
            public string Tag { get => tagLine; }
            public string PUUID { get => puuid; }

        }

        

        private HttpInstance http = HttpInstance.GetInstance;

        private string uriNickname { get; }
        private string uriTag { get; }

        public Account AccountInfo { get; set; }

        public List<string> MatchList { get; set; }



        public Summoner(string nickname, string tag) 
        { 
            uriNickname = Uri.EscapeDataString(nickname);
            uriTag = Uri.EscapeDataString(tag);

        }

        public async Task<string> GetAccountInfo()
        {
            string url = $"https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{uriNickname}/{uriTag}";

            try
            {
                HttpResponseMessage response = await http.Client.GetAsync(url);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                   
                    throw new Exception(response.StatusCode.ToString());
                }
                string strResponse = await response.Content.ReadAsStringAsync();

                AccountInfo = JsonSerializer.Deserialize<Account>(strResponse);

                
                Debug.WriteLine(AccountInfo.PUUID);
                return null ;

            }
            catch (Exception error)
            {
                Debug.WriteLine(error);
                return error.Message;
            }

        }

        public async Task<List<string>?> GetMatchList(int MaxIndex)
        {
            string url = $"https://europe.api.riotgames.com/lol/match/v5/matches/by-puuid/{AccountInfo.PUUID}/ids?start=0&count={MaxIndex}";
            
            try
            {
                HttpResponseMessage response = await http.Client.GetAsync(url);

                if (response.StatusCode != HttpStatusCode.OK)
                {

                    throw new Exception(response.StatusCode.ToString());
                }

                string strResponse = await response.Content.ReadAsStringAsync();
                List<string>? MatchList = JsonSerializer.Deserialize<List<string>>(strResponse);

                this.MatchList = MatchList;
                return MatchList;

            }
            catch (Exception error)
            {
                Debug.WriteLine(error);
                return null;
            }
        }

        public async Task<Match> GetMatch (string MatchId)
        {
            string url = $"https://europe.api.riotgames.com/lol/match/v5/matches/{MatchId}";

            try
            {
                HttpResponseMessage response = await http.Client.GetAsync(url);

                if (response.StatusCode != HttpStatusCode.OK)
                {

                    throw new Exception(response.StatusCode.ToString());
                }

                string strResponse = await response.Content.ReadAsStringAsync();
                Match match = JsonSerializer.Deserialize<Match>(strResponse);

                return match;

            }
            catch (Exception error)
            {
                Debug.WriteLine(error); 
                return null;
            }
        }

    }
}
