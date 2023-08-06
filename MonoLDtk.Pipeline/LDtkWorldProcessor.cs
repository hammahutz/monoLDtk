using Microsoft.Xna.Framework.Content.Pipeline;

using Newtonsoft.Json;

using TInput = System.String;
using TOutput = System.String;

namespace MonoLDtk.Pipeline;

[ContentProcessor(DisplayName = "LDtk World Processor")]
class Processor1 : ContentProcessor<TInput, TOutput>
{
    public override TOutput Process(TInput input, ContentProcessorContext context)
    {
        return default(TOutput);
    }
}
