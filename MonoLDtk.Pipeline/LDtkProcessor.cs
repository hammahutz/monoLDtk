using Microsoft.Xna.Framework.Content.Pipeline;

using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Pipeline;
[ContentProcessor(DisplayName = "LDtkProcessor")]
class LDtkProcessor : ContentProcessor<string, LDtk>
{
    public override LDtk Process(string input, ContentProcessorContext context) => new LDtk(input);

}
