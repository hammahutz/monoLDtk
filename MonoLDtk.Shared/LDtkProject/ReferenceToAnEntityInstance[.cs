using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject;

internal class ReferenceToAnEntityInstance
{
    /// <summary>
    /// IID of the refered EntityInstance
    /// </summary>
    [JsonProperty("entityIid")]
    internal Guid EntityIid { get; set; }

    /// <summary>
    /// IID of the LayerInstance containing the refered EntityInstance
    /// </summary>
    [JsonProperty("layerIid")]
    internal Guid LayerIid { get; set; }

    /// <summary>
    /// IID of the Level containing the refered EntityInstance
    /// </summary>
    [JsonProperty("levelIid")]
    internal Guid LevelIid { get; set; }

    /// <summary>
    /// IID of the World containing the refered EntityInstance
    /// </summary>
    [JsonProperty("worldIid")]
    internal Guid WorldIid { get; set; }
}
