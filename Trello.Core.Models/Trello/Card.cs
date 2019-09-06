using System;
using Newtonsoft.Json;
using Trello.Core.Models.CustomField;

namespace Trello.Core.Models.Trello
{
    public partial class Card
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("checkItemStates")]
        public object CheckItemStates { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("coordinates")]
        public object Coordinates { get; set; }

        [JsonProperty("creationMethod")]
        public object CreationMethod { get; set; }

        [JsonProperty("dateLastActivity")]
        public DateTimeOffset DateLastActivity { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("descData")]
        public DescData DescData { get; set; }

        [JsonProperty("dueReminder")]
        public object DueReminder { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("idLabels")]
        public object[] IdLabels { get; set; }

        [JsonProperty("idList")]
        public string IdList { get; set; }

        [JsonProperty("idMembersVoted")]
        public object[] IdMembersVoted { get; set; }

        [JsonProperty("idShort")]
        public long IdShort { get; set; }

        [JsonProperty("idAttachmentCover")]
        public object IdAttachmentCover { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("locationName")]
        public object LocationName { get; set; }

        [JsonProperty("manualCoverAttachment")]
        public bool ManualCoverAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("dueComplete")]
        public bool DueComplete { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("idChecklists")]
        public string[] IdChecklists { get; set; }

        [JsonProperty("idMembers")]
        public object[] IdMembers { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("shortUrl")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("customFieldItems")]
        public CustomFieldItem[] CustomFieldItems { get; set; }

    }
}