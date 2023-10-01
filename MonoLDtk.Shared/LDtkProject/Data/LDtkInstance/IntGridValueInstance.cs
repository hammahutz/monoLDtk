using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;

internal class IntGridValueInstance
{
    /// <summary>
    /// Coordinate ID in the layer grid
    /// </summary>
    [JsonProperty("coordId")]
    internal long CoordId { get; set; }

    /// <summary>
    /// IntGrid value
    /// </summary>
    [JsonProperty("v")]
    internal long V { get; set; }
}
