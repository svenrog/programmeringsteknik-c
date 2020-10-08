using Newtonsoft.Json;

namespace RecipeScraper.Models
{
    class InstructionDto
    {
        [JsonProperty("@Type")]
        public string Type { get; set; }
        public string Text { get; set; }
    }
}
