using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class DescData
    {
        [JsonProperty("emoji")]
        public Emoji Emoji { get; set; }
    }
}