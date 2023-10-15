using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Example.GameObjecs
{
    public class Art : GameAssetsManager
    {

        public GameAssets<Texture2D> Textures { get; private set; }
        public GameAssets<LDtk> World { get; private set; }


        public Art(ContentManager contentManager)
        {
            Textures = new GameAssets<Texture2D>(this, contentManager, new List<string>{
                Data.Textures.HeroIdle,
                Data.Textures.HeroRun,
                Data.Textures.LavaTileset
            });

            World = new GameAssets<LDtk>(this, contentManager, new List<string>{
                Data.World.Map1
            });

        }

        public override T Get<T>(string path)
        {
            if (Textures.IsType<T>())
            {
                return Textures.Get<T>(path);
            }
            if (World.IsType<T>())
            {
                return World.Get<T>(path);
            }

            return default;
        }
    }
}