namespace LOGON_APP
{
    internal class WeatherResponse
    {
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set; }
        public Weather[] weather { get; set; }
        public string name { get; set; }

    }
}
