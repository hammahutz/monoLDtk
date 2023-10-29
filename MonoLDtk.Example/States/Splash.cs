using System;

using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLDtk.Example.GameAssetManagers;
using MonoLDtk.Example.GameObjecs;
using MonoLDtk.Example.GameObjects;
using MonoLDtk.Shared;
using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.States;

namespace MonoLDtk.Example.States;

public class Splash : GameState<GameStateEnum>
{
    public GameObjectHandler GameObjectHandler { get; private set; }
    private string _debug;
    private Player _player;

    private Camera _camera ;

    public Splash(ContentManager contentManager) : base(contentManager) { }


    public override void Enter()
    {
        _camera = new Camera(Data.Graphics.Viewport);

        _player = new Player();
        GameObjectHandler = new GameObjectHandler(new Art(Content));
        GameObjectHandler.Add(_player);
        GameObjectHandler.Add(new World(Data.World.Map1));
    }
    public override void Update(GameTime gameTime)
    {
        _debug = $"Game Time: {gameTime.TotalGameTime.TotalSeconds}\n";
        _debug += $"FPS: {1 / gameTime.ElapsedGameTime.TotalSeconds}\n";
        _debug += $"{_camera}\n";

        GameObjectHandler.Update(gameTime);
        _camera.MoveCamera(_player.Position, _player.Size);


        var keyboard = Keyboard.GetState();

        if (keyboard.IsKeyDown(Keys.W))
            _camera.ZoomCamera(2, gameTime);

        if (keyboard.IsKeyDown(Keys.S))
            _camera.ZoomCamera(-2, gameTime);

        if (keyboard.IsKeyDown(Keys.Q))
            _camera.RollCamera(10, gameTime);

        if (keyboard.IsKeyDown(Keys.E))
            _camera.RollCamera(-10, gameTime);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin(transformMatrix: _camera.GetCameraMatrix, sortMode: SpriteSortMode.FrontToBack, samplerState: SamplerState.PointClamp);
        GameObjectHandler.Draw(spriteBatch);
        spriteBatch.End();

        spriteBatch.Begin();
        spriteBatch.DrawString(Global.Debug, _debug.ToString(), Vector2.Zero, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0.6f);
        spriteBatch.End();
    }

    public override void Exit()
    {
        GameObjectHandler.Depose();
    }

}
