using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Example.GameObjecs
{
    public class World : GameObject, IDraw, ILoad
    {
        private readonly string _worldPath;
        private LDtk _ldtk;

        public Vector2 Position { get; set; } = Vector2.Zero;

        public Rectangle? Size => Rectangle.Empty;

        public World(string path) => _worldPath = path;

        public void Load(GameAssetsManager gameAssetsManager)
        {
            _ldtk = gameAssetsManager.Get<LDtk>(_worldPath);
            _ldtk.LoadWorld(gameAssetsManager);
        }

        public void Draw(SpriteBatch spriteBatch) => _ldtk.Draw(spriteBatch);

        public void Unload() => _ldtk = null;
    }

}