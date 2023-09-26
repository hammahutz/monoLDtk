using System.ComponentModel.Design;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example.GameObjects
{
    public abstract class GameObject : IDrawable, IUpdateable
    {
        public bool IsAlive { get; set; } = true;
        public abstract void Load(ContentManager content);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}