using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.States;


namespace MonoLDtk.Example;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    public GameStateManager GameStateManager;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // GameObjectHandler = new GameObjectHandler(new Art(Content));

        // GameObjectHandler.Add(new World(GameObjectHandler, Data.World.Map1));
        // GameObjectHandler.Add(new Player(GameObjectHandler));
        GameStateManager = new GameStateManager(Content, GameStateEnum.Splash);

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

            // GameObjectHandler.Update(gameTime);
            GameStateManager.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        // GameObjectHandler.Draw(_spriteBatch);
        GameStateManager.Draw(_spriteBatch);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
