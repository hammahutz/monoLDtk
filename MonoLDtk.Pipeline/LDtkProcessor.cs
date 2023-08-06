using Microsoft.Xna.Framework.Content.Pipeline;

using Newtonsoft.Json;

using TInput = System.String;
using TOutput = MonoLDtk.Shared.LDtk;

namespace MonoLDtk.Pipeline;

[ContentProcessor(DisplayName = "LDtkProcessor")]
class Processor1 : ContentProcessor<TInput, TOutput>
{
    public override TOutput Process(TInput input, ContentProcessorContext context) => JsonConvert.DeserializeObject<TOutput>(input);
}
