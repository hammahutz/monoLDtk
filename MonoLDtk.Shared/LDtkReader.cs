using Microsoft.Xna.Framework.Content;


namespace MonoLDtk.Shared;
public class LDtkReader : ContentTypeReader<LDtk>
{
    protected override LDtk Read(ContentReader input, LDtk existingInstance) => existingInstance ?? new LDtk(input.ReadString());

}
