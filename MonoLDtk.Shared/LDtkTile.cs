﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.LDtkProject.LDtkInstance;

namespace MonoLDtk.Shared;

public class LDtkTile
{
    internal LDtkTile(TileInstance tileInstance, int tileSize)
    {

        Id = tileInstance.T;
        Alpha = (float)tileInstance.A;
        Flip = (SpriteEffects)(int)tileInstance.F;
        DestinationRectangle = new Rectangle((int)tileInstance.Px[0], (int)tileInstance.Px[1], tileSize, tileSize);
        SourceRectangle = new Rectangle((int)tileInstance.Src[0], (int)tileInstance.Src[1], tileSize, tileSize);
    }

    public long Id { get; private set; }
    public Rectangle SourceRectangle { get; private set; }
    public Rectangle DestinationRectangle { get; private set; }
    public float Alpha
    {
        get
        {
            return Alpha;
        }
        private set
        {
            Alpha = value;
            Color = new Color(Color, Alpha);
        }
    }
    public Color Color { get; private set; } = Color.White;
    public float Rotation { get; private set; } = 0;
    public Vector2 Origin { get; private set; } = Vector2.Zero;
    public SpriteEffects Flip { get; private set; } = 0;
    public float LayerDepth { get; private set; } = 0.5f;

    public void Draw(Texture2D texture, SpriteBatch spriteBatch)
    {
        spriteBatch.Draw
        (
            texture,
            DestinationRectangle,
            SourceRectangle,
            Color,
            Rotation,
            Origin,
            Flip,
            LayerDepth
        );
    }
}
