using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;

public class GameObjectHandler
{
    private List<GameObject> _gameObjects = new List<GameObject>();

    public void Add(GameObject gameObject) => _gameObjects.Add(gameObject);

    public event Action<ContentManager>? OnLoad;
    public event Action<GameTime>? OnUpdate;
    public event Action<SpriteBatch>? OnDraw;

    public void Load(ContentManager content) => OnLoad?.Invoke(content);
    public void Update(GameTime gameTime)
    {
        _gameObjects
            .Where(g => !g.IsAlive)
            .ToList()
            .ForEach(g =>
            {
                g.DestroyGameObject(this);
                _gameObjects.Remove(g);
            });


        OnUpdate?.Invoke(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch) => OnDraw?.Invoke(spriteBatch);

    // public void Load(ContentManager content) =>
    //     _gameObjects
    //         .Where(t => t is IDraw)
    //         .Select(s => s as IDraw)
    //         .ToList()
    //         .ForEach(id => id.Load(content));

    // public void Update(GameTime gameTime)
    // {
    //     _gameObjects = _gameObjects.Where(g => g.IsAlive).ToList();

    //     _gameObjects
    //         .Where(t => t is IUpdate)
    //         .Select(s => s as IUpdate)
    //         .ToList()
    //         .ForEach(iu => iu.Update(gameTime));
    // }

    // public void Draw(SpriteBatch spriteBatch) =>
    //     _gameObjects
    //         .Where(t => t is IDraw)
    //         .Select(s => s as IDraw)
    //         .ToList()
    //         .ForEach(id => id.Draw(spriteBatch));

}