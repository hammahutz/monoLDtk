using MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;

internal class EntityInstance
{
    /// <summary>
    /// Grid-based coordinates (`[x,y]` format)
    /// </summary>
    [JsonProperty("__grid")]
    internal long[] Grid { get; set; }

    /// <summary>
    /// Entity definition identifier
    /// </summary>
    [JsonProperty("__identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Pivot coordinates  (`[x,y]` format, values are from 0 to 1) of the Entity
    /// </summary>
    [JsonProperty("__pivot")]
    internal double[] Pivot { get; set; }

    /// <summary>
    /// The entity "smart" color, guessed from either Entity definition, or one its field
    /// instances.
    /// </summary>
    [JsonProperty("__smartColor")]
    internal string SmartColor { get; set; }

    /// <summary>
    /// Array of tags defined in this Entity definition
    /// </summary>
    [JsonProperty("__tags")]
    internal string[] Tags { get; set; }

    /// <summary>
    /// Optional TilesetRect used to display this entity (it could either be the default Entity
    /// tile, or some tile provided by a field value, like an Enum).
    /// </summary>
    [JsonProperty("__tile")]
    internal TilesetRectangle Tile { get; set; }

    /// <summary>
    /// Reference of the **Entity definition** UID
    /// </summary>
    [JsonProperty("defUid")]
    internal long DefUid { get; set; }

    /// <summary>
    /// An array of all custom fields and their values.
    /// </summary>
    [JsonProperty("fieldInstances")]
    internal FieldInstance[] FieldInstances { get; set; }

    /// <summary>
    /// Entity height in pixels. For non-resizable entities, it will be the same as Entity
    /// definition.
    /// </summary>
    [JsonProperty("height")]
    internal long Height { get; set; }

    /// <summary>
    /// Unique instance identifier
    /// </summary>
    [JsonProperty("iid")]
    internal Guid Iid { get; set; }

    /// <summary>
    /// Pixel coordinates (`[x,y]` format) in current level coordinate space. Don't forget
    /// optional layer offsets, if they exist!
    /// </summary>
    [JsonProperty("px")]
    internal long[] Px { get; set; }

    /// <summary>
    /// Entity width in pixels. For non-resizable entities, it will be the same as Entity
    /// definition.
    /// </summary>
    [JsonProperty("width")]
    internal long Width { get; set; }
}
