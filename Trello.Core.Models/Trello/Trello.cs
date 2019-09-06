using Newtonsoft.Json;

namespace Trello.Core.Models.Trello
{
    public partial class Trello
    {
        [JsonProperty("board")]
        public long Board { get; set; }

        [JsonProperty("card")]
        public long Card { get; set; }
    }
}