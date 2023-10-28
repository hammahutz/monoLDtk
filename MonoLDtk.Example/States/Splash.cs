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
    private string _debug;
    private Matrix _translation;
    private Player _player;
    private float _cameraSpeed = 10.0f;

    public GameObjectHandler GameObjectHandler { get; private set; }
    public Splash(ContentManager contentManager) : base(contentManager) { }



    public override void Enter()
    {
        GameObjectHandler = new GameObjectHandler(new Art(Content));

        _player = new Player();
        GameObjectHandler.Add(_player);

        GameObjectHandler.Add(new World(Data.World.Map1));
    }
    public override void Update(GameTime gameTime)
    {
        _debug = $"Game Time: {gameTime.TotalGameTime.TotalSeconds}\nFPS: {1 / gameTime.ElapsedGameTime.TotalSeconds}";
        GameObjectHandler.Update(gameTime);
        CalculateCamera();

    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        // Matrix.CreateOrthographic()
        spriteBatch.Begin(transformMatrix: _translation, sortMode: SpriteSortMode.FrontToBack);
        GameObjectHandler.Draw(spriteBatch);
        spriteBatch.End();
        
        spriteBatch.Begin();
        spriteBatch.DrawString(Global.Debug, _debug.ToString(), Vector2.Zero, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0.6f);
        spriteBatch.End();
    }

    private void CalculateCamera() => _translation = Matrix.CreateTranslation(Data.Graphics.WindowSize.ToVector3() / 2 - _player.Position.ToVector3());

    public override void Exit()
    {
        GameObjectHandler.Depose();
    }

}
