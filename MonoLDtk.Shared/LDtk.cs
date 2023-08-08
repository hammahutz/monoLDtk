using Newtonsoft.Json;

using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Shared;

public class LDtk
{
    internal LDtkData LDtkData;
    public string JSON => JsonConvert.SerializeObject(LDtkData) ?? "{}";


    public LDtk() => LDtkData = new LDtkData();
    public LDtk(string ldtkData) => SetLDtkData(ldtkData);


    public override string ToString() => JSON;
    public void SetLDtkData(string ldtkData) => LDtkData = JsonConvert.DeserializeObject<LDtkData>(ldtkData) ?? new LDtkData();
}