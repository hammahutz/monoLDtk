using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.States;

namespace MonoLDtk.Example.States;

public class PlayGame : GameState<GameStateEnum>
{
    public PlayGame(ContentManager contentManager) : base(contentManager) { }
    public override void Enter() { }
    public override void Update(GameTime gameTime) { }
    public override void Draw(SpriteBatch spriteBatch) { }
    public override void Exit() { }
}