using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects.Components;

public class AnimationController : IDraw, IUpdate, ILoad
{
    private Dictionary<string, Animation> Animations { get; set; } = new Dictionary<string, Animation>();
    public Animation CurrentAnimation { get; set; }
    public int FramesPerSecond { get; set; }
    public Vector2 Position
    {
        get => CurrentAnimation.Position;

        set
        {
            Animations
                .ToList()
                .ForEach(a => a.Value.Position = value);
        }
    }
    public bool IsFlipped
    {
        get => CurrentAnimation.IsFlipped;

        set
        {
            Animations
                .ToList()
                .ForEach(a => a.Value.IsFlipped = value);
        }
    }

    public AnimationController(List<string> texturePaths, int framesPerSecond)
    {
        FramesPerSecond = framesPerSecond;

        Animations = texturePaths
            .Select(s => new Animation(s, FramesPerSecond))
            .ToDictionary(d => d.SpriteSheet.Gfx.TexturePath, d => d);

        if (Animations.Count > 0)
            CurrentAnimation = Animations.First().Value;

    }

    public AnimationController(List<Animation> animations)
    {
        Animations = animations
            .ToDictionary(a => a.SpriteSheet.Gfx.TexturePath, a => a);

        if (Animations.Count > 0)
            CurrentAnimation = Animations.First().Value;
    }

    public void AddAnimation(Animation animation) => Animations.Add(animation.SpriteSheet.Gfx.TexturePath, animation);
    public void ChangeAnimation(string animationName)
    {
        if (animationName == CurrentAnimation.SpriteSheet.Gfx.TexturePath)
            return;

        CurrentAnimation = Animations[animationName];
    }

    public void Load(GameAssetsManager gameAssetsManager) => Animations.ToList().ForEach(a => a.Value.Load(gameAssetsManager));

    public void Update(GameTime gameTime) => CurrentAnimation.Update(gameTime);

    public void Draw(SpriteBatch spriteBatch) => CurrentAnimation.Draw(spriteBatch);

    public void Unload() =>
        Animations
            .ToList()
            .ForEach(a =>
                a.Value.Unload()
            );
}