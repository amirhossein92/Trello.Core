using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class AttachmentsByType
    {
        [JsonProperty("trello")]
        public Trello Trello { get; set; }
    }
}