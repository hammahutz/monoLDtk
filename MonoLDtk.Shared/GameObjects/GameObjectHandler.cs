using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoLDtk.Shared.GameObjects;

public class GameObjectHandler
{
    private List<GameObject> _gameObjects = new List<GameObject>();
    private GameAssetsManager _gameAssetsManager;

    public GameObjectHandler(GameAssetsManager gameAssetsManager)
    {
        _gameAssetsManager = gameAssetsManager;
    }


    public event Action<GameAssetsManager>? OnLoad;
    public event Action<GameTime>? OnUpdate;
    public event Action<SpriteBatch>? OnDraw;

    public void Add(GameObject gameObject)
    {
        _gameObjects.Add(gameObject);
        if (gameObject is IDraw)
        {
            ((IDraw)gameObject).Load(_gameAssetsManager);
        }
    }
    public void Load(ContentManager contentManager)
    {
        _gameAssetsManager.Load(contentManager);
        OnLoad?.Invoke(_gameAssetsManager);
    }

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



}