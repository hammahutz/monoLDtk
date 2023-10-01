using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data;

internal class LdtkTableOfContentEntry
{
    [JsonProperty("identifier")]
    internal string Identifier { get; set; }

    [JsonProperty("instances")]
    internal ReferenceToAnEntityInstance[] Instances { get; set; }
}
