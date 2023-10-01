using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class EnumTagValue
{
    [JsonProperty("enumValueId")]
    internal string EnumValueId { get; set; }

    [JsonProperty("tileIds")]
    internal long[] TileIds { get; set; }
}
