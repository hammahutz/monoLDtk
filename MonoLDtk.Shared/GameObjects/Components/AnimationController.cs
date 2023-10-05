using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects.Components;

public class AnimationController : IDraw, IUpdate
{
    private Dictionary<string, Animation> _animations { get; set; } = new Dictionary<string, Animation>();
    public Animation CurrentAnimation { get; set; }
    public int FramesPerSecond { get; set; }

    public AnimationController(List<string> texturePaths, int framesPerSecond)
    {
        FramesPerSecond = framesPerSecond;

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

    public void Load(GameAssetsManager gameAssetsManager) => _animations.ToList().ForEach(a => a.Value.Load(gameAssetsManager));

    public void Update(GameTime gameTime) => CurrentAnimation.Update(gameTime);

    public void Draw(SpriteBatch spriteBatch) => CurrentAnimation.Draw(spriteBatch);
}