using System;
using System.Diagnostics.Contracts;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example.GameObjects.Components;

public class Animation : IDrawable, IUpdateable
{
    public readonly SpriteSheet SpriteSheet;
    private int _framePerSecond;
    private double _counter = 0;

    public int FramePerSecond
    {
        get => _framePerSecond;
        set => _framePerSecond = Math.Max(1, value);
    }

    public double SecondsPerFrame => 1.0 / FramePerSecond;

    public Animation(string texturePath, int framePerSecond)
    {
        SpriteSheet = new SpriteSheet(texturePath);
        FramePerSecond = framePerSecond;
    }

    public void Load(ContentManager content) => SpriteSheet.Load(content);

    public void Update(GameTime gameTime)
    {
        _counter += gameTime.ElapsedGameTime.TotalSeconds;
        if (_counter > SecondsPerFrame)
        {
            SpriteSheet.CurrentGrid = new Point(SpriteSheet.CurrentGrid.X + 1, SpriteSheet.CurrentGrid.Y);

            if (SpriteSheet.CurrentGrid.X >= SpriteSheet.GridDimension.X)
                SpriteSheet.CurrentGrid = Point.Zero;

            SpriteSheet.Gfx.SourceRectangle = new Rectangle(SpriteSheet.CurrentTile, SpriteSheet.TileDimension);
            _counter = 0.0;
        }
    }

    public void Draw(SpriteBatch spriteBatch) => SpriteSheet.Draw(spriteBatch);
}