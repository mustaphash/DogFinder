using Newtonsoft.Json;

namespace Models.Finder
{
    public class Finder
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
