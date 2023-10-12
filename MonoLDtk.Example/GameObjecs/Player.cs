using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.GameObjects.Components;


namespace MonoLDtk.Example.GameObjects;

public class Player : GameObject, IUpdate, IDraw
{
    private double _counter = 0;
    private readonly AnimationController _animation = new AnimationController(new List<Animation>(){
        new Animation(Data.Textures.HeroRun, 24),
        new Animation(Data.Textures.HeroIdle, 5),
    });

    public Player()
    {
    }

    public void Load(GameAssetsManager gameAssetsManager) => _animation.Load(gameAssetsManager);

    public void Update(GameTime gameTime)
    {
        _counter += gameTime.ElapsedGameTime.TotalSeconds;
        if (_counter > 5)
        {
            _animation.ChangeAnimation(Data.Textures.HeroIdle);
            _counter = -5;
        }
        if (_counter > 0)
        {
            _animation.ChangeAnimation(Data.Textures.HeroRun);
        }

        _animation.Update(gameTime);

        if (Keyboard.GetState().IsKeyDown(Keys.Space))
        {
            Console.WriteLine("Space");
            IsAlive = false;
        }
    }

    public void Draw(SpriteBatch spriteBatch) => _animation.Draw(spriteBatch);

}