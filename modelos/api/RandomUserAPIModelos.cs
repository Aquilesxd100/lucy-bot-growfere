namespace bot_lucy_growfere.modelos.api
{
    public class RandomUserGETResponse
    {
        public RandomUserResult[] results { get; set; }
        public RandomUserGETInfo info { get; set; }
    }

    public class RandomUserResult
    {
        public string gender { get; set; }
        public RandomUserName name { get; set; }
        public RandomUserLocation location { get; set; }
        public string email { get; set; }
        public RandomUserLogin login { get; set; }
        public RandomUserDob dob { get; set; }
        public RandomUserRegistered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public RandomUserId id { get; set; }
        public RandomUserPicture picture { get; set; }
        public string nat { get; set; }
    }

    public class RandomUserName
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class RandomUserLocation
    {
        public RandomUserLocationStreet street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public RandomUserLocationCoordinates coordinates { get; set; }
        public RandomUserLocationTimezone timezone { get; set; }
    }

    public class RandomUserLocationStreet
    {
        public string name { get; set; }
        public int number { get; set; }
    }

    public class RandomUserLocationCoordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class RandomUserLocationTimezone
    {
        public string offset { get; set; }
        public string description { get; set; }
    }

    public class RandomUserLogin
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }

    public class RandomUserDob
    {
        public string date { get; set; }
        public int age { get; set; }
    }

    public class RandomUserRegistered
    {
        public string date { get; set; }
        public int age { get; set; }
    }

    public class RandomUserId
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class RandomUserPicture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }

    public class RandomUserGETInfo
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }
}