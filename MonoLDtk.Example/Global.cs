using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example
{
    public static class Global
    {
        public static SpriteFont Debug;

        public static void Load(ContentManager content) => Debug = content.Load<SpriteFont>("Font/Debug/Debug");
    }
}