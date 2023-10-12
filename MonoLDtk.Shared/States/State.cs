using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;

namespace MonoLDtk.Shared.States
{
    public abstract class State<EState>  where EState : Enum
    {
        public event Action<EState>? OnChangeState;
        public void ChangeState(EState nextState) => OnChangeState?.Invoke(nextState);
        public abstract void Enter();
        public abstract void Exit();
    }
}