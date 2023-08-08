using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;

using Newtonsoft.Json;

namespace MonoLDtk.Shared;
public class LDtkReader : ContentTypeReader<LDtk>
{
    protected override LDtk Read(ContentReader input, LDtk existingInstance) => new LDtk(input.ReadString());

}
