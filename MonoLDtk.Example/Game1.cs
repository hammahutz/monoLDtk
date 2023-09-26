using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.GameObjects;
using MonoLDtk.Example.GameObjects.Components;
using MonoLDtk.Shared;


namespace MonoLDtk.Example;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private LDtk world;
    public GameObjectHandler GameObjectHandler;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        GameObjectHandler = new GameObjectHandler();
        GameObjectHandler.Add(new Player());

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        world = Content.Load<LDtk>(Data.World.Map1);
        world.LoadWorld(Content);

        GameObjectHandler.Load(Content);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

            GameObjectHandler.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        world.Draw(_spriteBatch);
        GameObjectHandler.Draw(_spriteBatch);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
