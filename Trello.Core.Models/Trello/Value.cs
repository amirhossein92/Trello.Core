using System;
using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public class Value
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("checked", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool? Checked { get; set; }
    }
}