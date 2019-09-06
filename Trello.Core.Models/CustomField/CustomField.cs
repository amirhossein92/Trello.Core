﻿// Generated by https://quicktype.io

using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Trello.Core.Models.CustomField
{
    public partial class CustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idModel")]
        public string IdModel { get; set; }

        [JsonProperty("modelType")]
        public string ModelType { get; set; }

        [JsonProperty("fieldGroup")]
        public string FieldGroup { get; set; }

        [JsonProperty("display")]
        public Display Display { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pos")]
        public long Pos { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Option[] Options { get; set; }
    }

    public partial class Display
    {
        [JsonProperty("cardFront")]
        public bool CardFront { get; set; }
    }

    public partial class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idCustomField")]
        public string IdCustomField { get; set; }

        [JsonProperty("value")]
        public Value Value { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pos")]
        public long Pos { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class CustomField
    {
        public static CustomField[] FromJson(string json) => JsonConvert.DeserializeObject<CustomField[]>(json, CustomFieldConverter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CustomField[] self) => JsonConvert.SerializeObject(self, CustomFieldConverter.Settings);
    }

    internal static class CustomFieldConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
