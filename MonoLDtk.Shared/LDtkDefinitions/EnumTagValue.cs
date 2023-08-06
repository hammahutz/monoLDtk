using Newtonsoft.Json;

namespace MonoLDtk.Shared;

public class EnumTagValue
{
    [JsonProperty("enumValueId")]
    public string EnumValueId { get; set; }

    [JsonProperty("tileIds")]
    public long[] TileIds { get; set; }
}
