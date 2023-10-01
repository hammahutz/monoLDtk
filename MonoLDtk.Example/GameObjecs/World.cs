using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Example.GameObjecs
{
    public class World : GameObject, IDraw
    {
        private string _worldPath;
        private LDtk ldtk;
        public World(GameObjectHandler handler, string path) : base(handler)
        {
            _worldPath = path;

        }

        public void Load(ContentManager content)
        {
            ldtk = content.Load<LDtk>(_worldPath);
            ldtk.LoadWorld(content);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            ldtk.Draw(spriteBatch);
        }

    }
}