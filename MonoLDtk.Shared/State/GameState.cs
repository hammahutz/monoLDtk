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
    public abstract class GameState<EState> where EState : Enum
    {
        public ContentManager Content { get; private set; }

        public GameState(ContentManager content) => Content = content;
        public event Action<EState>? OnChangeState;


        public void ChangeState(EState nextState) => OnChangeState?.Invoke(nextState);
        public void Enter()
        {
            Initialize();
            LoadContent();

        }
        public void Exit()
        {
            UnloadContent();
            Depose();
        }
        public abstract void Initialize();
        public abstract void LoadContent();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void UnloadContent();
        public abstract void Depose();

    }
}