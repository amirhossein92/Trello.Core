using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class TrelloList
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}