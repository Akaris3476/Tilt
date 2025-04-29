using Microsoft.VisualBasic;
using System.Buffers;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tilt
{
    public partial class Form1 : Form
    {
        private Summoner summonerRu;
        private Summoner summonerEune;
        private Match lastMatchRu;
        private Match lastMatchEune;

        struct Game
        {
            public Match match;
            public Summoner summoner;
        }


        public Form1()
        {
            InitializeComponent();
            summonerRu = new("Женечка Тильт", "RU1");
            summonerEune = new("JenechkaTilt", "11111");

            Thread meowThread = new(meow);
            meowThread.Start();
        }


        private async void meow()
        {

            await summonerRu.GetAccountInfo();
            await summonerRu.GetMatchList(20);
            lastMatchRu = await summonerRu.GetMatch(summonerRu.MatchList[0]);

            await summonerEune.GetAccountInfo();
            await summonerEune.GetMatchList(20);
            lastMatchEune = await summonerEune.GetMatch(summonerEune.MatchList[0]);


        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            StartBtn.Visible = false;
            progressBar1.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);

                progressBar1.Value = i;
            }

            Debug.WriteLine(summonerEune.MatchList[0]);
            Debug.WriteLine(lastMatchRu.info.participants[lastMatchRu.FindPlayerIndex(summonerRu.AccountInfo.puuid)].championName);



            Thread.Sleep(800);
            Game lastGame; //obj where last match and summoner info stored
            
            if (lastMatchRu.info.gameEndTimestamp > lastMatchEune.info.gameEndTimestamp) //decides on what acc was last game
            {
                lastGame.match = lastMatchRu;
                lastGame.summoner = summonerRu;
            }
            else
            {
                lastGame.match = lastMatchEune;
                lastGame.summoner = summonerEune;
            }

            if (UnixToDate(lastGame.match.info.gameEndTimestamp).Date != DateTime.Today) //if last game happened today
            {
                RetrievePlayerData(lastGame.summoner, lastGame.match);
                NotTodayWindow();
                return;
            }

            Match? lastLostTodayMatchRu = await TodayDefeatMatch(summonerRu);
            Match? lastLostTodayMatchEune = await TodayDefeatMatch(summonerEune);

            //Game lastLostGame;//obj where last lost match and summoner info stored

            if (lastLostTodayMatchEune != null && lastLostTodayMatchRu != null) //lost games played today on both accs
            {
                if (lastLostTodayMatchRu.info.gameEndTimestamp > lastLostTodayMatchEune.info.gameEndTimestamp) //decides on what acc was last lost game today
                {
                    lastGame.match = lastLostTodayMatchRu;
                    lastGame.summoner = summonerRu;
                }
                else
                {
                    lastGame.match = lastLostTodayMatchEune;
                    lastGame.summoner = summonerEune;
                }

                RetrievePlayerData(lastGame.summoner, lastGame.match);
                DefeatWindow();
                return;

            }
            else if (lastLostTodayMatchEune != null) //today game lost only on eune
            {
                RetrievePlayerData(summonerEune, lastMatchEune);
                DefeatWindow();
                return;

            }
            else if (lastLostTodayMatchRu != null) //today game lost only on ru
            {
                RetrievePlayerData(summonerRu, lastMatchRu);
                DefeatWindow();
                return;
            }
            else
            {
                RetrievePlayerData(lastGame.summoner, lastGame.match);
                VictoryWindow();
                return;
            }

        }

        private async Task<Match?> TodayDefeatMatch(Summoner summoner)
        {
            for (int i = 0; summoner.MatchList[i] != null; i++)
            {
                var match = await summoner.GetMatch(summoner.MatchList[i]);

                if (UnixToDate(match.info.gameEndTimestamp).Date != DateTime.Today)
                {
                    break; 
                }
                if (match.info.participants[match.FindPlayerIndex(summoner.AccountInfo.puuid)].win)
                {
                    return match;
                }
            }
            return null;
        }

        private void RetrievePlayerData(Summoner summoner, Match match)
        {
            Participant Player = match.info.participants[match.FindPlayerIndex(summoner.AccountInfo.puuid)];

            ldamage.Text = $"Урон по чампам: {Player.totalDamageDealtToChampions.ToString()}";

            if (match.info.gameMode == "ARAM")
            {
                lrole.Visible = false;
            }
            else
            {
                lrole.Text = Player.role.ToLower();
            }

            lchamp.Text = Player.championName;
            lgameMode.Text = match.info.gameMode;
            lgamelength.Text = $"Длина катки: {match.info.gameDuration / 60}мин " +
                                            $"{match.info.gameDuration % 60}сек";

            if (Player.win)
            {
                lwinlose.Text = "Перемога";
            } else {
                lwinlose.Text = "Слитая катка";
                
            }
            ltag.Text = Player.riotIdTagline;
            lnick.Text = Player.riotIdGameName; 
            
            long timeDiff = DateToUnix(DateTime.Now) - match.info.gameEndTimestamp;
            timeDiff = timeDiff / 1000;
            llongago.Text = $"Прошло {timeDiff / 3600}часов {(timeDiff % 3600) / 60}мин";

            lkda.Text = $"КДА: {Player.kills}/{Player.deaths}/{Player.assists}";

        }


        public static DateTime UnixToDate(long unixTime)
        {
            DateTimeOffset meow = DateTimeOffset.FromUnixTimeMilliseconds(unixTime);
            DateTime dateTime = meow.LocalDateTime;
            return dateTime;
        }

        public static long DateToUnix(DateTime dateTime)
        {

            long unix = ((DateTimeOffset)dateTime).ToUnixTimeMilliseconds();
            return unix;
        }


        private void VictoryWindow()
        {
            progressBar1.Visible = false;

            endgameLabel.Text = "К превеликому удивлению, \r\nсегодня Женечка Тильт\r\n ещё не отсосал\r\n";
            DefeatPanel.Visible = true;

        }

        private void DefeatWindow()
        {
            progressBar1.Visible = false;
            llastkatka.Text = "Ласт слитая катка:";

            endgameLabel.Text = "Увы, вынужден сообщить, \r\nчто сегодня Женечка Тильт\r\n жёстко соснул хуйца \r\n";
            DefeatPanel.Visible = true;
        }

        private void NotTodayWindow()
        {
            progressBar1.Visible = false;

            endgameLabel.Text = "Сегодня Женечка Тильт \r\nв лигу не заходил, \r\nслава богу\r\n";
            DefeatPanel.Visible = true;

        }
    }
}
