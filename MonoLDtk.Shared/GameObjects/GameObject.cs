using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;
public abstract class GameObject
{
    public bool IsAlive { get; set; } = true;
    public GameObject(GameObjectHandler handler)
    {
        if (this is IDraw)
        {
            handler.OnLoad += ((IDraw)this).Load;
            handler.OnDraw += ((IDraw)this).Draw;
        }
        if (this is IUpdate)
            handler.OnUpdate += ((IUpdate)this).Update;
    }

    public void DestroyGameObject(GameObjectHandler handler)
    {
        Destroy();
        if (this is IDraw draw)
        {
            handler.OnLoad -= ((IDraw)this).Load;
            handler.OnDraw -= draw.Draw;
        }
        if (this is IUpdate update)
            handler.OnUpdate -= update.Update;
    }

    protected virtual void Destroy() { }
}