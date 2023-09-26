using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Example.GameObjects.Components;


namespace MonoLDtk.Example.GameObjects;

public class Player : GameObject
{
    private double _counter = 0;
    private readonly AnimationController _animation = new AnimationController(new List<Animation>()
    {
        new Animation(Data.Texture.HeroRun, 24),
        new Animation(Data.Texture.HeroIdle, 5),
    });

    public override void Load(ContentManager content) => _animation.Load(content);
    public override void Update(GameTime gameTime)
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
    }

    public override void Draw(SpriteBatch spriteBatch) => _animation.Draw(spriteBatch);
}