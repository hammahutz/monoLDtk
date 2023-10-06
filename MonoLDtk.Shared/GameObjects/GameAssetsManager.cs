using System;
using System.Collections;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects
{
    public abstract class GameAssetsManager
    {
        public event Action? OnLoadAction;
        public event Action? OnUnloadAction;

        public void Load() => OnLoadAction?.Invoke();

        public void Unload() => OnUnloadAction?.Invoke();

        public abstract T Get<T>(string path);
    }
}