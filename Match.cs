namespace tenniswjeff
{
    public class Match
    {
        private int matchID;
        private string playeronefName;
        private string playeronelName;
        private string playertwofName;
        private string playertwolName;
        private string winName;
        private int winSets;
        private int loseSets;

        public Match(int matchID, string playeronefName, string playeronelName, string playertwofName, string playertwolName, string winName, int winSets, int loseSets)
        {
            this.matchID = matchID;
            this.playeronefName = playeronefName;
            this.playeronelName = playeronelName;
            this.playertwofName = playertwofName;
            this.playertwolName = playertwolName;
            this.winName = winName;
            this.winSets = winSets;
            this.loseSets = loseSets;
        }
        public void SetMatchID(int matchID)
        {
            this.matchID = matchID;
        }
        public int GetMatchID()
        {
            return matchID;
        }
        public void SetPlayerOneFName(string playeronefName)
        {
            this.playeronefName = playeronefName;
        }
        public string GetPlayerOneFName()
        {
            return playeronefName;
        }
        public void SetPlayerOneLName(string playeronelName)
        {
            this.playeronelName = playeronelName;
        }
        public string GetPlayerOneLName()
        {
            return playeronelName;
        }
        public void SetPlayerTwoFName(string playertwofName)
        {
            this.playertwofName = playertwofName;
        }
        public string GetPlayerTwoFName()
        {
            return playertwofName;
        }
        public void SetPlayerTwoLName(string playertwolName)
        {
            this.playertwolName = playertwolName;
        }
        public string GetPlayerTwoLName()
        {
            return playertwolName;
        }
        public void SetWinName(string winName)
        {
            this.winName = winName;
        }
        public string GetWinName()
        {
            return winName;
        }
        public void SetWinSets(int winSets)
        {
            this.winSets = winSets;
        }
        public int GetWinSets()
        {
            return winSets;
        }
        public void SetLoseSets(int loseSets)
        {
            this.loseSets = loseSets;
        }
        public int GetLoseSets()
        {
            return loseSets;
        }
        public override string ToString()
        {
            return matchID + "\t" + playeronefName + "\t" + playeronelName + "\t" + playertwofName + "\t" + playertwolName + "\t" + winName + "\t" + winSets + "\t" + loseSets;
        }
 
        public string ToFile()
        {
            return matchID + "#" + playeronefName + "#" + playeronelName + "#" + playertwofName + "#" + playertwolName + "#" + winName + "#" + winSets + "#" + loseSets;
        }
        
    }
}