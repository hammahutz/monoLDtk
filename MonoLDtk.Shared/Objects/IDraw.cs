
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;

public interface IDraw
{
    public Vector2 Position {get; set;}
    public Rectangle? Size {get; }
    public void Draw(SpriteBatch spriteBatch);
}

