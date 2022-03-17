namespace TestAPI.Helpers
{
    public static class Generators
    {
        public static string GeneratePhoneCacheKey(string fromNo, string toNo)
        {
            return fromNo + "_" + toNo;
        }

        public static string GenerateTrackerKey(string fromNo)
        {
            return fromNo + "_Tracker";
        }

        public static bool CheckMatchingRule(this string domain, string searchword)
        {

            if (domain.Equals(searchword)||domain.Equals(searchword+"\n")
                || domain.Equals(searchword+"\r")|| domain.Equals(searchword+"\r\n") ) 
                return true;

            return false;
        }
    }
}
