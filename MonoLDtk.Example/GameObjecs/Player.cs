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
    private readonly AnimationController _animation = new AnimationController(new List<Animation>()
    {
        new Animation(Data.Texture.HeroRun, 24),
        new Animation(Data.Texture.HeroIdle, 5),
    });

    public Player(GameObjectHandler handler) : base(handler)
    {
    }

    public void Load(ContentManager content) => _animation.Load(content);

    public void Update(GameTime gameTime)
    {
        _counter += gameTime.ElapsedGameTime.TotalSeconds;
        if (_counter > 5)
        {
            _animation.ChangeAnimation(Data.Texture.HeroIdle);
            _counter = -5;
        }
        if (_counter > 0)
        {
            _animation.ChangeAnimation(Data.Texture.HeroRun);
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