using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class AutoLayerRuleDefinition
{
    /// <summary>
    /// If FALSE, the rule effect isn't applied, and no tiles are generated.
    /// </summary>
    [JsonProperty("active")]
    internal bool Active { get; set; }

    [JsonProperty("alpha")]
    internal double Alpha { get; set; }

    /// <summary>
    /// When TRUE, the rule will prevent other rules to be applied in the same cell if it matches
    /// (TRUE by default).
    /// </summary>
    [JsonProperty("breakOnMatch")]
    internal bool BreakOnMatch { get; set; }

    /// <summary>
    /// Chances for this rule to be applied (0 to 1)
    /// </summary>
    [JsonProperty("chance")]
    internal double Chance { get; set; }

    /// <summary>
    /// Checker mode Possible values: `None`, `Horizontal`, `Vertical`
    /// </summary>
    [JsonProperty("checker")]
    internal Checker Checker { get; set; }

    /// <summary>
    /// If TRUE, allow rule to be matched by flipping its pattern horizontally
    /// </summary>
    [JsonProperty("flipX")]
    internal bool FlipX { get; set; }

    /// <summary>
    /// If TRUE, allow rule to be matched by flipping its pattern vertically
    /// </summary>
    [JsonProperty("flipY")]
    internal bool FlipY { get; set; }

    /// <summary>
    /// Default IntGrid value when checking cells outside of level bounds
    /// </summary>
    [JsonProperty("outOfBoundsValue")]
    internal long? OutOfBoundsValue { get; set; }

    /// <summary>
    /// Rule pattern (size x size)
    /// </summary>
    [JsonProperty("pattern")]
    internal long[] Pattern { get; set; }

    /// <summary>
    /// If TRUE, enable Perlin filtering to only apply rule on specific random area
    /// </summary>
    [JsonProperty("perlinActive")]
    internal bool PerlinActive { get; set; }

    [JsonProperty("perlinOctaves")]
    internal double PerlinOctaves { get; set; }

    [JsonProperty("perlinScale")]
    internal double PerlinScale { get; set; }

    [JsonProperty("perlinSeed")]
    internal double PerlinSeed { get; set; }

    /// <summary>
    /// X pivot of a tile stamp (0-1)
    /// </summary>
    [JsonProperty("pivotX")]
    internal double PivotX { get; set; }

    /// <summary>
    /// Y pivot of a tile stamp (0-1)
    /// </summary>
    [JsonProperty("pivotY")]
    internal double PivotY { get; set; }

    /// <summary>
    /// Pattern width & height. Should only be 1,3,5 or 7.
    /// </summary>
    [JsonProperty("size")]
    internal long Size { get; set; }

    /// <summary>
    /// Array of all the tile IDs. They are used randomly or as stamps, based on `tileMode` value.
    /// </summary>
    [JsonProperty("tileIds")]
    internal long[] TileIds { get; set; }

    /// <summary>
    /// Defines how tileIds array is used Possible values: `Single`, `Stamp`
    /// </summary>
    [JsonProperty("tileMode")]
    internal TileMode TileMode { get; set; }

    /// <summary>
    /// Max random offset for X tile pos
    /// </summary>
    [JsonProperty("tileRandomXMax")]
    internal long TileRandomXMax { get; set; }

    /// <summary>
    /// Min random offset for X tile pos
    /// </summary>
    [JsonProperty("tileRandomXMin")]
    internal long TileRandomXMin { get; set; }

    /// <summary>
    /// Max random offset for Y tile pos
    /// </summary>
    [JsonProperty("tileRandomYMax")]
    internal long TileRandomYMax { get; set; }

    /// <summary>
    /// Min random offset for Y tile pos
    /// </summary>
    [JsonProperty("tileRandomYMin")]
    internal long TileRandomYMin { get; set; }

    /// <summary>
    /// Tile X offset
    /// </summary>
    [JsonProperty("tileXOffset")]
    internal long TileXOffset { get; set; }

    /// <summary>
    /// Tile Y offset
    /// </summary>
    [JsonProperty("tileYOffset")]
    internal long TileYOffset { get; set; }

    /// <summary>
    /// Unique Int identifier
    /// </summary>
    [JsonProperty("uid")]
    internal long Uid { get; set; }

    /// <summary>
    /// X cell coord modulo
    /// </summary>
    [JsonProperty("xModulo")]
    internal long XModulo { get; set; }

    /// <summary>
    /// X cell start offset
    /// </summary>
    [JsonProperty("xOffset")]
    internal long XOffset { get; set; }

    /// <summary>
    /// Y cell coord modulo
    /// </summary>
    [JsonProperty("yModulo")]
    internal long YModulo { get; set; }

    /// <summary>
    /// Y cell start offset
    /// </summary>
    [JsonProperty("yOffset")]
    internal long YOffset { get; set; }
}
