using Newtonsoft.Json;

namespace MonoLDtk.Shared;

public class LdtkTableOfContentEntry
{
    [JsonProperty("identifier")]
    public string Identifier { get; set; }

    [JsonProperty("instances")]
    public ReferenceToAnEntityInstance[] Instances { get; set; }
}
