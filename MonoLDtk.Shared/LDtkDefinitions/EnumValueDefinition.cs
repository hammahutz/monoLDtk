using MonoLDtk.Shared.LDtkTileset;

using Newtonsoft.Json;

namespace MonoLDtk.Shared;

public class EnumValueDefinition
{
    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonProperty("__tileSrcRect")]
    public long[] TileSrcRect { get; set; }

    /// <summary>
    /// Optional color
    /// </summary>
    [JsonProperty("color")]
    public long Color { get; set; }

    /// <summary>
    /// Enum value
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonProperty("tileId")]
    public long? TileId { get; set; }

    /// <summary>
    /// Optional tileset rectangle to represents this value
    /// </summary>
    [JsonProperty("tileRect")]
    public TilesetRectangle TileRect { get; set; }
}
