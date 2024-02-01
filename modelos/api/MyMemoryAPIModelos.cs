namespace bot_lucy_growfere.modelos.api
{
    public class MyMemoryGETResponse
    {
        public MyMemoryGETResponseData responseData { get; set; }
        public bool quotaFinished { get; set; }
        public string mtLangSupported { get; set; }
        public string responseDetails { get; set; }
        public int responseStatus { get; set; }
        public string responderId { get; set; }
        public int exception_code { get; set; }
        public MyMemoryGETResponseMatch[] matches { get; set; }
    }

    public class MyMemoryGETResponseData
    {
        public string translatedText { get; set; }
        public int match { get; set; }
    }

    public class MyMemoryGETResponseMatch
    {
        public string id { get; set; }
        public string segment { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public int quality { get; set; }
        public string reference { get; set; }
        public int usageCount { get; set; }
        public string subject { get; set; }
        public string translation { get; set; }
        public string createdBy { get; set; }
        public string lastUpdatedBy { get; set; }
        public string createDate { get; set; }
        public string lastUpdateDate { get; set; }
        public float match { get; set; }
    }
}
