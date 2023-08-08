using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class FieldDefinition
{
    /// <summary>
    /// Human readable value type. Possible values: `Int, Float, String, Bool, Color,
    /// ExternEnum.XXX, LocalEnum.XXX, Point, FilePath`.<br/>  If the field is an array, this
    /// field will look like `Array<...>` (eg. `Array<Int>`, `Array<Point>` etc.)<br/>  NOTE: if
    /// you enable the advanced option **Use Multilines type**, you will have "*Multilines*"
    /// instead of "*String*" when relevant.
    /// </summary>
    [JsonProperty("__type")]
    internal string Type { get; set; }

    /// <summary>
    /// Optional list of accepted file extensions for FilePath value type. Includes the dot:
    /// `.ext`
    /// </summary>
    [JsonProperty("acceptFileTypes")]
    internal string[] AcceptFileTypes { get; set; }

    /// <summary>
    /// Possible values: `Any`, `OnlySame`, `OnlyTags`, `OnlySpecificEntity`
    /// </summary>
    [JsonProperty("allowedRefs")]
    internal AllowedRefs AllowedRefs { get; set; }

    [JsonProperty("allowedRefsEntityUid")]
    internal long? AllowedRefsEntityUid { get; set; }

    [JsonProperty("allowedRefTags")]
    internal string[] AllowedRefTags { get; set; }

    [JsonProperty("allowOutOfLevelRef")]
    internal bool AllowOutOfLevelRef { get; set; }

    /// <summary>
    /// Array max length
    /// </summary>
    [JsonProperty("arrayMaxLength")]
    internal long? ArrayMaxLength { get; set; }

    /// <summary>
    /// Array min length
    /// </summary>
    [JsonProperty("arrayMinLength")]
    internal long? ArrayMinLength { get; set; }

    [JsonProperty("autoChainRef")]
    internal bool AutoChainRef { get; set; }

    /// <summary>
    /// TRUE if the value can be null. For arrays, TRUE means it can contain null values
    /// (exception: array of Points can't have null values).
    /// </summary>
    [JsonProperty("canBeNull")]
    internal bool CanBeNull { get; set; }

    /// <summary>
    /// Default value if selected value is null or invalid.
    /// </summary>
    [JsonProperty("defaultOverride")]
    internal dynamic DefaultOverride { get; set; }

    /// <summary>
    /// User defined documentation for this field to provide help/tips to level designers about
    /// accepted values.
    /// </summary>
    [JsonProperty("doc")]
    internal string Doc { get; set; }

    [JsonProperty("editorAlwaysShow")]
    internal bool EditorAlwaysShow { get; set; }

    [JsonProperty("editorCutLongValues")]
    internal bool EditorCutLongValues { get; set; }

    /// <summary>
    /// Possible values: `Hidden`, `ValueOnly`, `NameAndValue`, `EntityTile`, `LevelTile`,
    /// `Points`, `PointStar`, `PointPath`, `PointPathLoop`, `RadiusPx`, `RadiusGrid`,
    /// `ArrayCountWithLabel`, `ArrayCountNoLabel`, `RefLinkBetweenPivots`,
    /// `RefLinkBetweenCenters`
    /// </summary>
    [JsonProperty("editorDisplayMode")]
    internal EditorDisplayMode EditorDisplayMode { get; set; }

    /// <summary>
    /// Possible values: `Above`, `Center`, `Beneath`
    /// </summary>
    [JsonProperty("editorDisplayPos")]
    internal EditorDisplayPos EditorDisplayPos { get; set; }

    [JsonProperty("editorDisplayScale")]
    internal double EditorDisplayScale { get; set; }

    /// <summary>
    /// Possible values: `ZigZag`, `StraightArrow`, `CurvedArrow`, `ArrowsLine`, `DashedLine`
    /// </summary>
    [JsonProperty("editorLinkStyle")]
    internal EditorLinkStyle EditorLinkStyle { get; set; }

    [JsonProperty("editorShowInWorld")]
    internal bool EditorShowInWorld { get; set; }

    [JsonProperty("editorTextPrefix")]
    internal string EditorTextPrefix { get; set; }

    [JsonProperty("editorTextSuffix")]
    internal string EditorTextSuffix { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonProperty("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// TRUE if the value is an array of multiple values
    /// </summary>
    [JsonProperty("isArray")]
    internal bool IsArray { get; set; }

    /// <summary>
    /// Max limit for value, if applicable
    /// </summary>
    [JsonProperty("max")]
    internal double? Max { get; set; }

    /// <summary>
    /// Min limit for value, if applicable
    /// </summary>
    [JsonProperty("min")]
    internal double? Min { get; set; }

    /// <summary>
    /// Optional regular expression that needs to be matched to accept values. Expected format:
    /// `/some_reg_ex/g`, with optional "i" flag.
    /// </summary>
    [JsonProperty("regex")]
    internal string Regex { get; set; }

    [JsonProperty("symmetricalRef")]
    internal bool SymmetricalRef { get; set; }

    /// <summary>
    /// Possible values: &lt;`null`&gt;, `LangPython`, `LangRuby`, `LangJS`, `LangLua`, `LangC`,
    /// `LangHaxe`, `LangMarkdown`, `LangJson`, `LangXml`, `LangLog`
    /// </summary>
    [JsonProperty("textLanguageMode")]
    internal TextLanguageMode? TextLanguageMode { get; set; }

    /// <summary>
    /// UID of the tileset used for a Tile
    /// </summary>
    [JsonProperty("tilesetUid")]
    internal long? TilesetUid { get; set; }

    /// <summary>
    /// Internal enum representing the possible field types. Possible values: F_Int, F_Float,
    /// F_String, F_Text, F_Bool, F_Color, F_Enum(...), F_Point, F_Path, F_EntityRef, F_Tile
    /// </summary>
    [JsonProperty("type")]
    internal string FieldDefinitionType { get; set; }

    /// <summary>
    /// Unique Int identifier
    /// </summary>
    [JsonProperty("uid")]
    internal long Uid { get; set; }

    /// <summary>
    /// If TRUE, the color associated with this field will override the Entity or Level default
    /// color in the editor UI. For Enum fields, this would be the color associated to their
    /// values.
    /// </summary>
    [JsonProperty("useForSmartColor")]
    internal bool UseForSmartColor { get; set; }
}
