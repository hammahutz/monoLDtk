


using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

using Newtonsoft.Json;

using MonoLDtk.Shared;


namespace MonoLDtk.Pipeline;

[ContentTypeWriter]
public class LDtkWriter : ContentTypeWriter<LDtk>
{
    protected override void Write(ContentWriter output, LDtk value) => output.Write(JsonConvert.SerializeObject(value));

    public override string GetRuntimeReader(TargetPlatform targetPlatform) => "MonoLDtk.Shared.LDtkReader, MonoLDtk.Shared";
}