using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.GameAssetManagers;
using MonoLDtk.Example.GameObjecs;
using MonoLDtk.Example.GameObjects;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.States;

namespace MonoLDtk.Example.States;

public class Splash : GameState<GameStateEnum>
{
    public GameObjectHandler GameObjectHandler {get; private set;}
    public Splash(ContentManager contentManager) : base(contentManager){}
    public override void Enter()
    {
        GameObjectHandler = new GameObjectHandler(new Art(Content));
        GameObjectHandler.Add(new Player());
        GameObjectHandler.Add(new World(Data.World.Map1));
    }
    public override void Update(GameTime gameTime)
    {
        GameObjectHandler.Update(gameTime);
    }
    public override void Draw(SpriteBatch spriteBatch)
    {
         GameObjectHandler.Draw(spriteBatch);
    }
    public override void Exit()
    {
        GameObjectHandler.UnloadContent();
        GameObjectHandler.Depose();
    }

}
