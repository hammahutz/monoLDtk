
using System;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Example;

public static class Data
{
    public static class World
    {
        public const string Map1 = "World/world1";
    }
    public static class Texture
    {
        public const string HeroIdle = "Texture/LavaCaves/Character/Hero/CharacterIdle";
        public const string HeroRun = "Texture/LavaCaves/Character/Hero/CharacterRun";
    }
    public static class Sprite
    {
        public const int FramePerSecond = 24;
        public static readonly Point Size = new Point(32);
    }
}
