namespace CurrencyExtractor.Models
{
    public class APIV4
    {
        public string @base { get; set; }
        public string date { get; set; }
        public int time_last_updated { get; set; }
        public RatesV4 rates { get; set; }
    }
}