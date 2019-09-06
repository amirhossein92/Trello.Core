using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class Badges
    {
        [JsonProperty("attachmentsByType")]
        public AttachmentsByType AttachmentsByType { get; set; }

        [JsonProperty("location")]
        public bool Location { get; set; }

        [JsonProperty("votes")]
        public long Votes { get; set; }

        [JsonProperty("viewingMemberVoted")]
        public bool ViewingMemberVoted { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("fogbugz")]
        public string Fogbugz { get; set; }

        [JsonProperty("checkItems")]
        public long CheckItems { get; set; }

        [JsonProperty("checkItemsChecked")]
        public long CheckItemsChecked { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("attachments")]
        public long Attachments { get; set; }

        [JsonProperty("description")]
        public bool Description { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("dueComplete")]
        public bool DueComplete { get; set; }
    }
}