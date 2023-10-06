using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Example.GameObjecs
{
    public class World : GameObject, IDraw
    {
        private readonly string _worldPath;
        private LDtk _ldtk;
        public World(GameObjectHandler handler, string path) : base(handler) => _worldPath = path;

        public void Load(GameAssetsManager gameAssetsManager)
        {
            _ldtk = gameAssetsManager.Get<LDtk>(_worldPath);
            _ldtk.LoadWorld(gameAssetsManager);
        }

        public void Draw(SpriteBatch spriteBatch) => _ldtk.Draw(spriteBatch);

       }

}