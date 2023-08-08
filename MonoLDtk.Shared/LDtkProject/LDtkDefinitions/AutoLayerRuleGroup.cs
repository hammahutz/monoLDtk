using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class AutoLayerRuleGroup
{
    [JsonProperty("active")]
    internal bool Active { get; set; }

    /// <summary>
    /// *This field was removed in 1.0.0 and should no longer be used.*
    /// </summary>
    [JsonProperty("collapsed")]
    internal bool? Collapsed { get; set; }

    [JsonProperty("isOptional")]
    internal bool IsOptional { get; set; }

    [JsonProperty("name")]
    internal string Name { get; set; }

    [JsonProperty("rules")]
    internal AutoLayerRuleDefinition[] Rules { get; set; }

    [JsonProperty("uid")]
    internal long Uid { get; set; }

    [JsonProperty("usesWizard")]
    internal bool UsesWizard { get; set; }
}
