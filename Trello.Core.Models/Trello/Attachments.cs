using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class Attachments
    {
        [JsonProperty("perCard")]
        public PerCard PerCard { get; set; }
    }
}