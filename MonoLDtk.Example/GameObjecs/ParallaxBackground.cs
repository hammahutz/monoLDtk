using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.GameObjects.Components;

namespace MonoLDtk.Example.GameObjecs
{
    public class ParallaxBackground : GameObject, ILoad, IDraw, IUpdate
    {
        private Camera _camera;
        private float _parallaxFactor;
        public Vector2 Position { get => Gfx.Position; set => Gfx.Position = value; }
        public Rectangle? Size => Gfx.Size;
        public Gfx Gfx { get; private set; }

        public ParallaxBackground(string texturePath, Camera camera, float parallaxFactor, float DrawOrder)
        {
            Gfx = new Gfx(texturePath) {LayerDepth = DrawOrder};
            _camera = camera;
            _parallaxFactor = parallaxFactor;
        }

        public void Load(GameAssetsManager gameAssetsManager) => Gfx.Load(gameAssetsManager);

        public void Update(GameTime gameTime)
        {
            var newPosition = -_camera.Position.ToVector2() + _camera.Position.ToVector2() / _parallaxFactor ;

            newPosition.Floor();
            Position = newPosition;
        }

        public void Draw(SpriteBatch spriteBatch) => Gfx.Draw(spriteBatch);

        public void Unload() => Gfx.Unload();
    }
}