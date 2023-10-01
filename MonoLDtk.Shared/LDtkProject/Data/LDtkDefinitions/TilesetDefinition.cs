using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class TilesetDefinition
{
    /// <summary>
    /// Grid-based height
    /// </summary>
    [JsonProperty("__cHei")]
    internal long CHei { get; set; }

    /// <summary>
    /// Grid-based width
    /// </summary>
    [JsonProperty("__cWid")]
    internal long CWid { get; set; }

    /// <summary>
    /// The following data is used internally for various optimizations. It's always synced with
    /// source image changes.
    /// </summary>
    [JsonProperty("cachedPixelData")]
    internal Dictionary<string, dynamic> CachedPixelData { get; set; }

    /// <summary>
    /// An array of custom tile metadata
    /// </summary>
    [JsonProperty("customData")]
    internal TileCustomMetadata[] CustomData { get; set; }

    /// <summary>
    /// If this value is set, then it means that this atlas uses an internal LDtk atlas image
    /// instead of a loaded one. Possible values: &lt;`null`&gt;, `LdtkIcons`
    /// </summary>
    [JsonProperty("embedAtlas")]
    internal EmbedAtlas? EmbedAtlas { get; set; }

    /// <summary>
    /// Tileset tags using Enum values specified by `tagsSourceEnumId`. This array contains 1
    /// element per Enum value, which contains an array of all Tile IDs that are tagged with it.
    /// </summary>
    [JsonProperty("enumTags")]
    internal EnumTagValue[] EnumTags { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonProperty("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Distance in pixels from image borders
    /// </summary>
    [JsonProperty("padding")]
    internal long Padding { get; set; }

    /// <summary>
    /// Image height in pixels
    /// </summary>
    [JsonProperty("pxHei")]
    internal long PxHei { get; set; }

    /// <summary>
    /// Image width in pixels
    /// </summary>
    [JsonProperty("pxWid")]
    internal long PxWid { get; set; }

    /// <summary>
    /// Path to the source file, relative to the current project JSON file<br/>  It can be null
    /// if no image was provided, or when using an embed atlas.
    /// </summary>
    [JsonProperty("relPath")]
    internal string RelPath { get; set; }

    /// <summary>
    /// Array of group of tiles selections, only meant to be used in the editor
    /// </summary>
    [JsonProperty("savedSelections")]
    internal Dictionary<string, dynamic>[] SavedSelections { get; set; }

    /// <summary>
    /// Space in pixels between all tiles
    /// </summary>
    [JsonProperty("spacing")]
    internal long Spacing { get; set; }

    /// <summary>
    /// An array of user-defined tags to organize the Tilesets
    /// </summary>
    [JsonProperty("tags")]
    internal string[] Tags { get; set; }

    /// <summary>
    /// Optional Enum definition UID used for this tileset meta-data
    /// </summary>
    [JsonProperty("tagsSourceEnumUid")]
    internal long? TagsSourceEnumUid { get; set; }

    [JsonProperty("tileGridSize")]
    internal long TileGridSize { get; set; }

    /// <summary>
    /// Unique Intidentifier
    /// </summary>
    [JsonProperty("uid")]
    internal long Uid { get; set; }
}
