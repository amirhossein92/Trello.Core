using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Trello.Core.Models.Trello;

namespace Trello.Core.Models
{
    public partial class Card
    {
        public static Card[] FromJson(string json) => JsonConvert.DeserializeObject<Card[]>(json, TrelloCardConverter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Card[] self) => JsonConvert.SerializeObject(self, TrelloCardConverter.Settings);
    }

    internal static class TrelloCardConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                // IdBoardConverter.Singleton,
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    // internal class IdBoardConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(IdBoard) || t == typeof(IdBoard?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         if (value == "5be2cc890ae52216797d6fa0")
    //         {
    //             return IdBoard.The5Be2Cc890Ae52216797D6Fa0;
    //         }
    //         throw new Exception("Cannot unmarshal type IdBoard");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (IdBoard)untypedValue;
    //         if (value == IdBoard.The5Be2Cc890Ae52216797D6Fa0)
    //         {
    //             serializer.Serialize(writer, "5be2cc890ae52216797d6fa0");
    //             return;
    //         }
    //         throw new Exception("Cannot marshal type IdBoard");
    //     }

    //     public static readonly IdBoardConverter Singleton = new IdBoardConverter();
    // }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ok")
            {
                return Status.Ok;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Ok)
            {
                serializer.Serialize(writer, "ok");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
