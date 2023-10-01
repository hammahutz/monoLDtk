using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;


internal class Definitions
{
    /// <summary>
    /// All entities definitions, including their custom fields
    /// </summary>
    [JsonProperty("entities")]
    internal EntityDefinition[] Entities { get; set; }

    /// <summary>
    /// All internal enums
    /// </summary>
    [JsonProperty("enums")]
    internal EnumDefinition[] Enums { get; set; }

    /// <summary>
    /// Note: external enums are exactly the same as `enums`, except they have a `relPath` to
    /// point to an external source file.
    /// </summary>
    [JsonProperty("externalEnums")]
    internal EnumDefinition[] ExternalEnums { get; set; }

    /// <summary>
    /// All layer definitions
    /// </summary>
    [JsonProperty("layers")]
    internal LayerDefinition[] Layers { get; set; }

    /// <summary>
    /// All custom fields available to all levels.
    /// </summary>
    [JsonProperty("levelFields")]
    internal FieldDefinition[] LevelFields { get; set; }

    /// <summary>
    /// All tilesets
    /// </summary>
    [JsonProperty("tilesets")]
    internal TilesetDefinition[] Tilesets { get; set; }
}
