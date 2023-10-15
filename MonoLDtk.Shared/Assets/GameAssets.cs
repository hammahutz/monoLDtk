using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Shared.GameObjects
{
    public class GameAssets<T>
    {
        private Dictionary<string, T> _assets;
        private ContentManager _contentManager;
        public readonly List<string>? AssetPaths;


        public GameAssets(GameAssetsManager gameAssetsManager, ContentManager contentManager, List<string> assetPaths)
        {
            AssetPaths = assetPaths;
            _contentManager = contentManager;
            _assets = new Dictionary<string, T>();

            gameAssetsManager.OnLoadAction += Load;
            gameAssetsManager.OnUnloadAction += Unload;
        }

        public void Load() => AssetPaths?.ForEach(path => _assets.Add(path, _contentManager.Load<T>(path)));
        public void Unload() => _contentManager.UnloadAssets(AssetPaths);

        private T Get(string path)
        {
            if (!_assets.ContainsKey(path))
            {
                Console.WriteLine($"Warning tries to load an unload asset: {path}. Try to load the asset...");
                _assets.Add(path, _contentManager.Load<T>(path));
            }
            return _assets[path];
        }

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
            if (IsType<Y>())
            {
                return (Y)Convert.ChangeType(Get(path), typeof(Y));
            }
            return default;
        }
    }
}
