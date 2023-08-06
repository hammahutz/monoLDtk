using MonoLDtk.Shared.LDtkTileset;

using Newtonsoft.Json;

namespace MonoLDtk.Shared;

public class IntGridValueDefinition
{
    [JsonProperty("color")]
    public string Color { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonProperty("identifier")]
    public string Identifier { get; set; }

    [JsonProperty("tile")]
    public TilesetRectangle Tile { get; set; }

    /// <summary>
    /// The IntGrid value itself
    /// </summary>
    [JsonProperty("value")]
    public long Value { get; set; }
}
