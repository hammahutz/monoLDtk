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
        public event Action<ContentManager>? OnLoadAction;
        public event Action<ContentManager>? OnUnloadAction;

        public void Load(ContentManager contentManager) => OnLoadAction?.Invoke(contentManager);

        public void Unload(ContentManager contentManager) => OnUnloadAction?.Invoke(contentManager);

        public abstract T Get<T>(string path);
    }
}