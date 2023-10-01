using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Shared.LDtkProject;
public class LDtkReader : ContentTypeReader<LDtk>
{
    protected override LDtk Read(ContentReader input, LDtk existingInstance) => new LDtk(input.ReadString());

}
