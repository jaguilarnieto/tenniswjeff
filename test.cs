namespace tenniswjeff
{
    public class test
    {
        private int playerID;
        private string playerfName;
        private string playerlName;
        private bool playerLevel;
        private string bLevel;
        private string iLevel;
        private string eLevel;

        public test(int playerID, string playerfName, string playerlName, bool playerLevel, string bLevel, string iLevel, string eLevel)
        {
            this.playerID = playerID;
            this.playerfName = playerfName;
            this.playerlName = playerlName;
            this.playerLevel = playerLevel;
            this.bLevel = bLevel;
            this.iLevel = iLevel;
            this.eLevel = eLevel;
        }

        public test()
        {}
    }
}