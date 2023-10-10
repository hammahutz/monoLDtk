using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;

public interface IDraw
{
    public void Load(GameAssetsManager gameAssetsManager);
    public void Draw(SpriteBatch spriteBatch);
}

