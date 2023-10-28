using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using MonoLDtk.Shared;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.GameObjects.Components;


namespace MonoLDtk.Example.GameObjects;

public class Player : GameObject, IUpdate, IDraw, ILoad
{
    private double _counter = 0;
    private float _speed = 100;
    private bool _isFlipped = false;
    private readonly AnimationController _animation = new AnimationController(new List<Animation>(){
        new Animation(Data.Textures.HeroRun, 24),
        new Animation(Data.Textures.HeroIdle, 5),
    });

    public Vector2 Position { get => _animation.Position; set => _animation.Position = value; }

    public Player()
    {
    }

    public void Load(GameAssetsManager gameAssetsManager) => _animation.Load(gameAssetsManager);

    public void Update(GameTime gameTime)
    {
        HandleInput(gameTime);
        _animation.Update(gameTime);
    }

    private void HandleInput(GameTime gameTime)
    {
        var keyboard = Keyboard.GetState();

        //TODO Implemnet CommandPattern
        //TODO Codesmeell parameters
        if (keyboard.IsKeyDown(Keys.D))
        {
            MoveX(_speed, Data.Textures.HeroRun, gameTime);
            _isFlipped = false;
        }
        else if (keyboard.IsKeyDown(Keys.A))
        {
            MoveX(-_speed, Data.Textures.HeroRun,gameTime);
            _isFlipped = true;
        }
        else
            MoveX(0, Data.Textures.HeroIdle, gameTime);

    }

    public void MoveX(float deltaX, string animation, GameTime time)
    {
        Position = Position.MoveX(deltaX, time);
        _animation.ChangeAnimation(animation);
        _animation.IsFlipped = _isFlipped;
    }


    public void Draw(SpriteBatch spriteBatch) => _animation.Draw(spriteBatch);

    public void Unload() => _animation.Unload();
}