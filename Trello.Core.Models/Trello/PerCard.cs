using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class PerCard
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("disableAt")]
        public long DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public long WarnAt { get; set; }
    }
}