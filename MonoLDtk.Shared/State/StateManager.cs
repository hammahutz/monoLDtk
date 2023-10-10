using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.State
{
    public abstract class StateManager<EState> where EState : Enum
    {
        public Dictionary<EState, GameState<EState>> States { get; private set; }
        protected GameState<EState> CurrentState;
        public StateManager(ContentManager contentManager, EState startState)
        {
            States = GetStates(contentManager);
            TransitionToState(startState);
        }
        protected abstract Dictionary<EState, GameState<EState>> GetStates(ContentManager contentManager);

        public void TransitionToState(EState nextState)
        {
            if (CurrentState != null)
            {
                CurrentState.Exit();
                CurrentState.OnChangeState -= TransitionToState;
            }

            CurrentState = States[nextState];

            CurrentState.OnChangeState += TransitionToState;
            CurrentState.Enter();
        }

        public void Update(GameTime gameTime) => CurrentState.Update(gameTime);
        public void Draw(SpriteBatch spriteBatch) => CurrentState.Draw(spriteBatch);
    }
}