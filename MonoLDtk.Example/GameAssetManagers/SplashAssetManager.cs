using System;
using System.Collections.Generic;

using Microsoft.VisualBasic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Example.GameObjecs;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Example.GameAssetManagers;

class SplashAssetManager : GameAssetsManager
{
    GameAssets<Texture2D> _textures;
    GameAssets<LDtk> _worlds;
    public SplashAssetManager(ContentManager content)
    {
        _textures = new GameAssets<Texture2D>(this, content, new List<string>{
            Data.Textures.HeroIdle,
            Data.Textures.HeroRun,
            Data.Textures.LavaTileset
        });
        _worlds = new GameAssets<LDtk>(this, content, new List<string>{
            Data.World.Map1
        });
    }
    public override T Get<T>(string path)
    {
        if (_textures.IsType<T>())
        {
            return _textures.Get<T>(path);
        }
        if (_worlds.IsType<T>())
        {
            return _worlds.Get<T>(path);
        }
        return default;
    }
}