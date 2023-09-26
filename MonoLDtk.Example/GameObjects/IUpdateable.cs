using Microsoft.Xna.Framework;

namespace MonoLDtk.Example.GameObjects;

public interface IUpdateable
{
    public void Update(GameTime gameTime);
}