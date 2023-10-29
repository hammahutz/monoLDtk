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
    private List<GameObject>? _gameObjects;
    public GameAssetsManager? GameAssetManager {get; private set;}

    public GameObjectHandler(GameAssetsManager? gameAssetsManager)
    {
        _gameObjects = new List<GameObject>();

        GameAssetManager = gameAssetsManager;
        GameAssetManager?.Load();
    }


    public event Action<GameTime>? OnUpdate;
    public event Action<SpriteBatch>? OnDraw;

    public void Add(GameObject gameObject)
    {
        if (gameObject == null)
            return;

        gameObject.Initialize(this);

        if (gameObject is ILoad && GameAssetManager != null)
        {
            ((ILoad)gameObject).Load(GameAssetManager);
        }

        _gameObjects.Add(gameObject);
    }

    public void RemoveExpiredGameObjects() => _gameObjects?
        .Where(g => !g.IsAlive)
        .ToList()
        .ForEach(gameObject =>
        {
            gameObject.DeposeGameObject(this);
            _gameObjects.Remove(gameObject);
        });

    public void Update(GameTime gameTime)
    {
        RemoveExpiredGameObjects();
        OnUpdate?.Invoke(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch) => OnDraw?.Invoke(spriteBatch);
    public void Depose()
    {
        _gameObjects?.ForEach(g => g.DeposeGameObject(this));
        _gameObjects = null;
        GameAssetManager?.Unload();
        GameAssetManager = null;
    }
}