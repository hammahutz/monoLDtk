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