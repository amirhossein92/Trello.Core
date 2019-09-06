using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class Limits
    {
        [JsonProperty("attachments")]
        public Attachments Attachments { get; set; }

        [JsonProperty("checklists")]
        public Attachments Checklists { get; set; }

        [JsonProperty("stickers")]
        public Attachments Stickers { get; set; }
    }
}