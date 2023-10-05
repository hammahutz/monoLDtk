using System.Collections.Generic;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;

namespace MonoLDtk.Example.GameObjecs;

public sealed class Test : ATest
{
    public Dictionary<string, Texture2D> Textures { get; private set; }
    public Dictionary<string, World> Worlds { get; private set; }

    public Test(ContentManager contentManager) : base(contentManager)
    {
        Textures = LoadContent<Texture2D>(new List<string>{
            Data.Textures.HeroIdle,
            Data.Textures.HeroRun
        });

        Worlds = LoadContent<World>(new List<string>{
            Data.World.Map1
        });
    }
}



