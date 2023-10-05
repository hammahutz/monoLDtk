using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Shared.GameObjects
{
    public class GameAssets<T>
    {
        private Dictionary<string, T> _assets = new Dictionary<string, T>();

        public readonly List<string>? AssetPaths;

        public GameAssets(GameAssetsManager gameAssetsManager, List<string> assetPaths)
        {
            AssetPaths = assetPaths;

            gameAssetsManager.OnLoadAction += Load;
            gameAssetsManager.OnUnloadAction += Unload;
        }

        public void Load(ContentManager contentManager) => AssetPaths?.ForEach(path => _assets.Add(path, contentManager.Load<T>(path)));
        public void Unload(ContentManager contentManager)
        {
            if (AssetPaths != null)
            {
                contentManager.UnloadAssets(AssetPaths);
            }
        }

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