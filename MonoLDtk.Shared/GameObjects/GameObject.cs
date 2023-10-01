using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.GameObjects;
public abstract class GameObject
{
    public bool IsAlive { get; set; } = true;
    public GameObject(GameObjectHandler handler)
    {
        if (this is IDraw)
        {
            IDraw drawable = this as IDraw;
            handler.OnLoad += drawable.Load;
            handler.OnDraw += drawable.Draw;
        }
        if (this is IUpdate)
        {
            IUpdate? updatable = this as IUpdate;
            handler.OnUpdate += updatable.Update;
        }
    }

    public void DestroyGameObject(GameObjectHandler handler)
    {
        if (this is IDraw)
        {
            IDraw drawable = this as IDraw;
            handler.OnLoad -= drawable.Load;
            handler.OnDraw -= drawable.Draw;
        }
        if (this is IUpdate)
        {
            IUpdate? updatable = this as IUpdate;
            handler.OnUpdate -= updatable.Update;
        }
    }

    public virtual void Destroy()
    {
        
    }
}