using System.Diagnostics.Contracts;

using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Shared.GameObjects
{
    public class GameAssets<T>
    {
        private Dictionary<string, T> _assets = new Dictionary<string, T>();
        private ContentManager _contentManager;
        public readonly List<string>? AssetPaths;


        public GameAssets(GameAssetsManager gameAssetsManager, ContentManager contentManager, List<string> assetPaths)
        {
            AssetPaths = assetPaths;
            _contentManager = contentManager;

            gameAssetsManager.OnLoadAction += Load;
            gameAssetsManager.OnUnloadAction += Unload;
        }

        public void Load() => AssetPaths?.ForEach(path => _assets.Add(path, _contentManager.Load<T>(path)));
        public void Unload() => _contentManager.UnloadAssets(AssetPaths);

        public T Get(string path) => _assets[path];

        public bool IsType<Y>()
        {
            if (typeof(T) == typeof(Y))
            {
                return true;
            }
            return false;
        }
        public Y Get<Y>(string path)
        {
            return (Y)Convert.ChangeType(Get(path), typeof(Y));
        }
    }
}
