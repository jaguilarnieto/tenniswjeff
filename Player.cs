namespace tenniswjeff
{
    public class Player
    {
        private int playerID;
        private string playerfName;
        private string playerlName;
        private bool playerLevel;
        private string bLevel;
        private string iLevel;
        private string eLevel;

        public Player(int playerID, string playerfName, string playerlName, bool playerLevel, string bLevel, string iLevel, string eLevel)
        {
            this.playerID = playerID;
            this.playerfName = playerfName;
            this.playerlName = playerlName;
            this.playerLevel = playerLevel;
            this.bLevel = bLevel;
            this.iLevel = iLevel;
            this.eLevel = eLevel;
        }

        public Player()
        {}


        public void SetPlayerID(int playerID)
        {
            this.playerID = playerID;
        }
        public int GetPlayerID()
        {
            return playerID;
        }
        public void SetPlayerFName(string playerfName)
        {
            this.playerfName = playerfName;
        }
        public string GetPlayerFName()
        {
            return playerfName;
        }
        public void SetPlayerLName(string playerlName)
        {
            this.playerlName = playerlName;
        }
        public string GetPlayerLName()
        {
            return playerlName;
        }
        public void SetPlayerLevel(bool playerLevel)
        {
            this.playerLevel = playerLevel;
        }
        public bool GetPlayerLevel()
        {
            return playerLevel;
        }
        public void SetBLevel(string bLevel)
        {
            this.bLevel = bLevel;
        }
        public string GetBLevel()
        {
            return bLevel;
        }
        public void SetILevel(string iLevel)
        {
            this.iLevel = iLevel;
        }
        public string GetILevel()
        {
            return iLevel;
        }
        public void SetELevel(string eLevel)
        {
            this.eLevel = eLevel;
        }
        public string GetELevel()
        {
            return eLevel;
        }

        public override string ToString()
        {
            return playerID + "\t" + playerfName + "\t" + playerlName + "\t" + playerLevel + "\t" + bLevel + "\t" + iLevel + "\t" + eLevel;
        }
 
        public string ToFile()
        {
            return playerID + "#" + playerfName + "#" + playerlName + "#" + playerLevel + "#" + bLevel + "#" + iLevel + "#" + eLevel;
        }
        
    }
}