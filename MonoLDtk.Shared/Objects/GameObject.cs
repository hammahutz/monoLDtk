using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;
public abstract class GameObject
{
    public bool IsAlive { get; set; } = true;

    public void Initialize(GameObjectHandler handler)
    {
        if (this is IDraw)
            handler.OnDraw += ((IDraw)this).Draw;

        if (this is IUpdate)
            handler.OnUpdate += ((IUpdate)this).Update;
    }

    public void DeposeGameObject(GameObjectHandler handler)
    {
        if (this is IDraw draw)
            handler.OnDraw -= draw.Draw;

        if (this is IUpdate update)
            handler.OnUpdate -= update.Update;
    }

}