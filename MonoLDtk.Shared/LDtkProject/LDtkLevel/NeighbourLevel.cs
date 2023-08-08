using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkLevel;

internal class NeighbourLevel
{
    /// <summary>
    /// A single lowercase character tipping on the level location (`n`orth, `s`outh, `w`est,
    /// `e`ast).
    /// </summary>
    [JsonProperty("dir")]
    internal string Dir { get; set; }

    /// <summary>
    /// Neighbour Instance Identifier
    /// </summary>
    [JsonProperty("levelIid")]
    internal Guid LevelIid { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
    /// by: `levelIid`
    /// </summary>
    [JsonProperty("levelUid")]
    internal long? LevelUid { get; set; }
}
