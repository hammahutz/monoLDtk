using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject;

internal  class LdtkCustomCommand
{
    [JsonProperty("command")]
    internal string Command { get; set; }

    /// <summary>
    /// Possible values: `Manual`, `AfterLoad`, `BeforeSave`, `AfterSave`
    /// </summary>
    [JsonProperty("when")]
    internal When When { get; set; }
}