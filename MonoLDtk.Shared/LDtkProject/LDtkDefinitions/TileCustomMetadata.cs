using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class TileCustomMetadata
{
    [JsonProperty("data")]
    internal string Data { get; set; }

    [JsonProperty("tileId")]
    internal long TileId { get; set; }
}
