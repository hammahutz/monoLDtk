using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;

namespace MonoLDtk.Shared.State
{
    public abstract class GameState
    {
        protected SpriteBatch? _spriteBatch;
        protected ContentManager? _contentManager;
        public abstract void Initialize();

        public void LoadContent(GraphicsDevice graphicsDevice, ContentManager contentManager)
        {
            _spriteBatch = new SpriteBatch(graphicsDevice);
            _contentManager = contentManager;

            LoadContentState();
        }
        protected abstract void LoadContentState();

        public void Update(GameTime gameTime)
        {
            UpdateState(gameTime);
        }
        protected abstract void UpdateState(GameTime gameTime);

        public void Draw(GameTime gameTime)
        {
            _spriteBatch?.Begin();
            DrawState(gameTime);
            _spriteBatch?.End();
        }

        protected abstract void DrawState(GameTime gameTime);
    }
}