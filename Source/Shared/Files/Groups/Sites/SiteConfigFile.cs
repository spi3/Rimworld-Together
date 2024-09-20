namespace Shared 
{
    public class SiteConfigFile 
    {
        public string DefName;
        public string overrideName = "";
        public string overrideDescription = "";

        public string[] DefNameCost;
        public int[] Cost;

        public RewardFile Rewards = new RewardFile();

        public SiteConfigFile Clone() 
        {
            byte[] data = Serializer.ConvertObjectToBytes(this);
            return Serializer.ConvertBytesToObject<SiteConfigFile>(data);
        }
    }
}