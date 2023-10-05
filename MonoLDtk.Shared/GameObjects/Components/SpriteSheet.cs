using System;
using System.Security.Cryptography.X509Certificates;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects.Components;

public class SpriteSheet : IDraw
{
    private Point _currentGrid = Point.Zero;

    public Gfx Gfx { get; private set; }

    public Point TileDimension { get; private set; } = new Point(32); //TODO Add global pixel art dimension
    public Point GridDimension { get; private set; }

    public Point CurrentTile => CurrentGrid * TileDimension;
    public Point CurrentGrid
    {
        get => _currentGrid;
        set
        {
            int x = Math.Clamp(value.X, 0, GridDimension.X);
            int y = Math.Clamp(value.Y, 0, GridDimension.Y);
            _currentGrid = new Point(x, y);
        }
    }
    public SpriteSheet(string texturePath) => Gfx = new Gfx(texturePath) { SourceRectangle = new Rectangle(CurrentGrid, TileDimension) };

    public void Load(GameAssetsManager gameAssetsManager)
    {
        Gfx.Load(gameAssetsManager);

        GridDimension = new Point
        (
            Gfx.Texture.Width / TileDimension.X,
            Gfx.Texture.Height / TileDimension.Y
        );
    }
    public void Draw(SpriteBatch spriteBatch) => Gfx.Draw(spriteBatch);
}