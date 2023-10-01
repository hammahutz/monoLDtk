using MonoLDtk.Shared.LDtkProject.Data.LDtkLevel;

using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data;

internal class World
{
    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonProperty("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Unique instance identifer
    /// </summary>
    [JsonProperty("iid")]
    internal Guid Iid { get; set; }

    /// <summary>
    /// All levels from this world. The order of this array is only relevant in
    /// `LinearHorizontal` and `linearVertical` world layouts (see `worldLayout` value).
    /// Otherwise, you should refer to the `worldX`,`worldY` coordinates of each Level.
    /// </summary>
    [JsonProperty("levels")]
    internal Level[] Levels { get; set; }

    /// <summary>
    /// Default new level height
    /// </summary>
    [JsonProperty("defaultLevelHeight")]
    internal long DefaultLevelHeight { get; set; }

    /// <summary>
    /// Default new level width
    /// </summary>
    [JsonProperty("defaultLevelWidth")]
    internal long DefaultLevelWidth { get; set; }

    /// <summary>
    /// Height of the world grid in pixels.
    /// </summary>
    [JsonProperty("worldGridHeight")]
    internal long WorldGridHeight { get; set; }

    /// <summary>
    /// Width of the world grid in pixels.
    /// </summary>
    [JsonProperty("worldGridWidth")]
    internal long WorldGridWidth { get; set; }

    /// <summary>
    /// An enum that describes how levels are organized in this project (ie. linearly or in a 2D
    /// space). Possible values: `Free`, `GridVania`, `LinearHorizontal`, `LinearVertical`, `null`
    /// </summary>
    [JsonProperty("worldLayout")]
    internal WorldLayout? WorldLayout { get; set; }
}
