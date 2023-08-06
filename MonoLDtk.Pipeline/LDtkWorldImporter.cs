using System.IO;

using Microsoft.Xna.Framework.Content.Pipeline;

using TImport = System.String;

namespace MonoLDtk.Pipeline;

[ContentImporter(".ldtk", DisplayName = "LDtk World Importer", DefaultProcessor = "LDtk World Processor")]
public class Importer1 : ContentImporter<TImport>
{
    public override TImport Import(string filename, ContentImporterContext context)
    {
        using (var reader = new StreamReader(filename)){
            return reader.ReadToEnd();
        }
    }
}
