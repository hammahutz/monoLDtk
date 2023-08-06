using Newtonsoft.Json;

namespace MonoLDtk.Shared;

public class TileCustomMetadata
{
    [JsonProperty("data")]
    public string Data { get; set; }

    [JsonProperty("tileId")]
    public long TileId { get; set; }
}
