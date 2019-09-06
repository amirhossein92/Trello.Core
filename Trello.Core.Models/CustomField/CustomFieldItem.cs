using Newtonsoft.Json;

namespace Trello.Core.Models.CustomField
{
    public class CustomFieldItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idValue", NullValueHandling = NullValueHandling.Ignore)]
        public string IdValue { get; set; }

        [JsonProperty("idCustomField")]
        public string IdCustomField { get; set; }

        [JsonProperty("idModel")]
        public string IdModel { get; set; }

        [JsonProperty("modelType")]
        public string ModelType { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Value Value { get; set; }
    }
}