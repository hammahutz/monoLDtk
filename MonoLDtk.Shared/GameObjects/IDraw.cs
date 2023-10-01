using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;

public interface IDraw
{
    public void Load(ContentManager content);
    public void Draw(SpriteBatch spriteBatch);
}

