using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.States;
using MonoLDtk.Shared.States;


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
        Global.Load(Content);
        Data.Graphics.Viewport = GraphicsDevice.Viewport;

        GameStateManager = new GameStateManager(Content);
        GameStateManager.TransitionToState(GameStateEnum.Splash);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        GameStateManager.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        GameStateManager.Draw(_spriteBatch);

        base.Draw(gameTime);
    }
}
