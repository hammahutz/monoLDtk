using MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class IntGridValueDefinition
{
    [JsonProperty("color")]
    internal string Color { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonProperty("identifier")]
    internal string Identifier { get; set; }

    [JsonProperty("tile")]
    internal TilesetRectangle Tile { get; set; }

    /// <summary>
    /// The IntGrid value itself
    /// </summary>
    [JsonProperty("value")]
    internal long Value { get; set; }
}
