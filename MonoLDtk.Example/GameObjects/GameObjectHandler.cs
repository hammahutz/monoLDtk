using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example.GameObjects.Components;

public class GameObjectHandler
{
    private List <GameObject> _gameObjects = new List<GameObject>();
    public void Add(GameObject gameObject) => _gameObjects.Add(gameObject);
    public void Load(ContentManager content) => _gameObjects.ForEach(g => g.Load(content));
    public void Update(GameTime gameTime)
    {
        _gameObjects.ForEach(g => g.Update(gameTime));
        _gameObjects = _gameObjects.Where(g => g.IsAlive).ToList();
    }

    public void Draw(SpriteBatch spriteBatch) => _gameObjects.ForEach(g => g.Draw(spriteBatch));

}