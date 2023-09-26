using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Example.GameObjects.Components;

public class AnimationController : IDrawable, IUpdateable
{
    private Dictionary<string, Animation> _animations { get; set; } = new Dictionary<string, Animation>();
    public Animation CurrentAnimation { get; set; }
    public int FramesPerSecond = Data.Sprite.FramePerSecond; //TODO Add a global animation speed

    public AnimationController(List<string> texturePaths)
    {
        _animations = texturePaths
            .Select(s => new Animation(s, FramesPerSecond))
            .ToDictionary(d => d.SpriteSheet.Gfx.TexturePath, d => d);

        if (_animations.Count > 0)
            CurrentAnimation = _animations.First().Value;

    }

    public AnimationController(List<Animation> animations)
    {
        _animations = animations
            .ToDictionary(a => a.SpriteSheet.Gfx.TexturePath, a => a);

        if (_animations.Count > 0)
            CurrentAnimation = _animations.First().Value;
    }

    public void AddAnimation(Animation animation) => _animations.Add(animation.SpriteSheet.Gfx.TexturePath, animation);
    public void ChangeAnimation(string animationName)
    {
        if (animationName == CurrentAnimation.SpriteSheet.Gfx.TexturePath)
            return;

        CurrentAnimation = _animations[animationName];
    }

    public void Load(ContentManager content) => _animations.ToList().ForEach(a => a.Value.Load(content));

    public void Update(GameTime gameTime) => CurrentAnimation.Update(gameTime);

    public void Draw(SpriteBatch spriteBatch) => CurrentAnimation.Draw(spriteBatch);
}