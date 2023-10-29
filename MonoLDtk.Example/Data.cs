
using System;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example;

public static class Data
{
    public static class Assets
    {
        public const string Texture2D = "Texture2D";
        public const string World = "World";
    }
    public static class World
    {
        public const string Map1 = "World/world1";
    }
    public static class Textures
    {
        public const string HeroIdle = "Texture/LavaCaves/Character/Hero/CharacterIdle";
        public const string HeroRun = "Texture/LavaCaves/Character/Hero/CharacterRun";
        public const string LavaTileset = "Texture/LavaCaves/Tileset/Lava_tileset";
        public const string Background = "Texture/LavaCaves/Background/BG_far";
        public const string Middleground = "Texture/LavaCaves/Background/BG_near";
        public const string Foreground = "Texture/LavaCaves/Decorantions/RuinsDecorations";
    }
    public static class Sprite
    {
        public const int FramePerSecond = 24;
        public static readonly Point Size = new Point(32);

    }
    public static class DrawOrder
    {

        public const float Background = 0.0f;
        public const float Middleground = 0.1f;
        public const float Foreground = 1f;
        public const float Player = 0f;

    }
    public static class Graphics
    {
        public static Point WindowSize { get; set; }
        public static Viewport Viewport { get; set; }
    }
}
