using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.GameAssetManagers;
using MonoLDtk.Example.GameObjecs;
using MonoLDtk.Example.GameObjects;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.State;

namespace MonoLDtk.Example.States;

public class Splash : GameState<GameStateEnum>
{
    private GameObjectHandler _gameObjectHandler;
    public Splash(ContentManager content) : base(content) { }
    public override void Initialize() => _gameObjectHandler = new GameObjectHandler(new SplashAssetManager(Content));
    public override void LoadContent()
    {
        _gameObjectHandler.Add(new World(_gameObjectHandler, Data.World.Map1));
        _gameObjectHandler.Add(new Player(_gameObjectHandler));
    }

    public override void Update(GameTime gameTime)
    {
        _gameObjectHandler.Update(gameTime);

        if (Keyboard.GetState().IsKeyDown(Keys.Space))
        {
           ChangeState(GameStateEnum.MainMenu);
        }
    }

    public override void Draw(SpriteBatch spriteBatch) => _gameObjectHandler.Draw(spriteBatch);
    public override void UnloadContent() => _gameObjectHandler.UnloadContent();
    public override void Depose() => _gameObjectHandler.Depose();
}
