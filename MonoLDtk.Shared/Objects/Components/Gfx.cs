using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects.Components;

public class Gfx : IDraw
{
    public string? TexturePath { get; }
    public Texture2D? Texture { get; set; }
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Rectangle? SourceRectangle { get; set; } = null;
    public Color Color { get; set; } = Color.White;
    public float Rotation { get; set; } = 0f;
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public Vector2 Scale { get; set; } = Vector2.One;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    public Gfx(string? texturePath) => TexturePath = texturePath;

    public void Load(GameAssetsManager gameAssetsManager) => Texture = gameAssetsManager.Get<Texture2D>(TexturePath);

    public void Draw(SpriteBatch spriteBatch) => spriteBatch.Draw(Texture, Position, SourceRectangle, Color, Rotation, Origin, Scale, Effects, LayerDepth);

}