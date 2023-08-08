using MonoLDtk.Shared.LDtkProject.LDtkTileset;

using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class EnumValueDefinition
{
    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonProperty("__tileSrcRect")]
    internal long[] TileSrcRect { get; set; }

    /// <summary>
    /// Optional color
    /// </summary>
    [JsonProperty("color")]
    internal long Color { get; set; }

    /// <summary>
    /// Enum value
    /// </summary>
    [JsonProperty("id")]
    internal string Id { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonProperty("tileId")]
    internal long? TileId { get; set; }

    /// <summary>
    /// Optional tileset rectangle to represents this value
    /// </summary>
    [JsonProperty("tileRect")]
    internal TilesetRectangle TileRect { get; set; }
}
