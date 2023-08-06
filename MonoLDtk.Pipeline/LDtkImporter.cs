using System.IO;

using Microsoft.Xna.Framework.Content.Pipeline;

using TImport = System.String;

namespace MonoLDtk.Pipeline;

[ContentImporter(".ldtk", DisplayName = "LDtkImporter", DefaultProcessor = "LDtkProcessor")]
public class Importer1 : ContentImporter<TImport>
{
    public override TImport Import(string filename, ContentImporterContext context)
    {
        string stream;
        using (var reader = new StreamReader(filename))
        {
            stream = reader.ReadToEnd();
        }

        return stream;
    }
}
