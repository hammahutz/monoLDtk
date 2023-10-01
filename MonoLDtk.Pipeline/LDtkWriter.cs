using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

using Newtonsoft.Json;

using MonoLDtk.Shared;
using MonoLDtk.Shared.LDtkProject;


namespace MonoLDtk.Pipeline;

[ContentTypeWriter]
public class LDtkWriter : ContentTypeWriter<LDtk>
{
    protected override void Write(ContentWriter output, LDtk ldtk) => output.Write(ldtk.ToString());

    public override string GetRuntimeReader(TargetPlatform targetPlatform) => "MonoLDtk.Shared.LDtkProject.LDtkReader, MonoLDtk.Shared";
}