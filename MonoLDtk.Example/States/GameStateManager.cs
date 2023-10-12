using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Example.GameObjecs;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.States;

namespace MonoLDtk.Example.States;

public class GameStateManager : StateManager<GameStateEnum>
{
    public Dictionary<GameStateEnum, GameState<GameStateEnum>> States;

    public ContentManager Content { get; private set; }

    public GameStateManager(ContentManager contentManager)
    {
        Content = contentManager;
        States = new Dictionary<GameStateEnum, GameState<GameStateEnum>>(){
                {GameStateEnum.Splash, new Splash(Content)},
                {GameStateEnum.MainMenu, new MainMenu(Content)},
                {GameStateEnum.PlayGame, new PlayGame(Content)}
            };
    }

    protected override State<GameStateEnum> GetState(GameStateEnum state) => States[state];

    public void Update(GameTime gameTime) => (CurrentState as GameState<GameStateEnum>).Update(gameTime);
    public void Draw(SpriteBatch spriteBatch) => (CurrentState as GameState<GameStateEnum>).Draw(spriteBatch);
}
