using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared;

public class Camera
{
    public Vector3 Position { get; private set; } = Vector3.Zero;
    public float Rotation { get; private set; } = 0f;
    public Vector3 Zoom { get; private set; } = Vector3.One;
    public Rectangle WindowSize { get; private set; } = Rectangle.Empty;

    public Camera(Viewport viewport)
    {
        WindowSize = viewport.Bounds;
    }

    public Matrix GetCameraMatrix =>
        Matrix.CreateTranslation(Position) *
        Matrix.CreateRotationZ(MathHelper.ToRadians(Rotation)) *
        Matrix.CreateScale(Zoom)*
        Matrix.CreateTranslation(WindowSize.Center.ToVector3());

    public void MoveCamera(Vector2 followObject, Rectangle? objectSize)
    {
        objectSize = objectSize ?? Rectangle.Empty;
        Vector3 position = -(followObject.ToVector3() + objectSize.Value.Center.ToVector3());
        position.Round();
        Position = position;
    }
    public void SetCameraRoll(float rotation) => Rotation = rotation;
    public void RollCamera(float deltaRotation, GameTime gameTime) => Rotation += deltaRotation * (float)gameTime.ElapsedGameTime.TotalSeconds;

    public void SetZoom(float zoom) => Zoom = new Vector3(zoom, zoom, 1);
    public void ZoomCamera(float deltaZoom, GameTime gameTime)
    {
        deltaZoom = Zoom.X + deltaZoom * (float)gameTime.ElapsedGameTime.TotalSeconds;
        Zoom = new Vector3(deltaZoom, deltaZoom, 1);
    }

    public override string ToString() => $"Position: {Position} Rotation: {Rotation} Zoom: {Zoom} Window Size : {WindowSize}";

}