using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example.GameObjects;

public interface IDrawable
{
    public void Load(ContentManager content);
    public void Draw(SpriteBatch spriteBatch);
}

