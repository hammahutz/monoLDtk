using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;

using MonoLDtk.Shared.State;

namespace MonoLDtk.Example.States;

public partial class GameStateManager : StateManager<GameStateEnum>
{
    public GameStateManager(ContentManager contentManager, GameStateEnum startState) : base(contentManager, startState)
    {
    }

    protected override Dictionary<GameStateEnum, GameState<GameStateEnum>> GetStates(ContentManager contentManager)
    {
        return new Dictionary<GameStateEnum, GameState<GameStateEnum>>(){
            {GameStateEnum.Splash, new Splash(contentManager)},
            {GameStateEnum.MainMenu, new MainMenu(contentManager)},
            {GameStateEnum.PlayGame, new PlayGame(contentManager)},
        };
    }

}
