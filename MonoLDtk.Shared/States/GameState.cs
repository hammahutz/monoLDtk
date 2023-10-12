using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;

namespace MonoLDtk.Shared.States
{
    public abstract class GameState<EState> : State<EState> where EState : Enum
    {
        public ContentManager Content { get; private set; }
        public GameState(ContentManager contentManager) => Content = contentManager;

        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}