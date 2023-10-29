
using Microsoft.Xna.Framework;

namespace MonoLDtk.Shared
{
    public static class Extension
    {
        public static Vector2 Move(this Vector2 vector, float x, float y, GameTime gameTime)
        {
            float xVelocity = x * (float)gameTime.ElapsedGameTime.TotalSeconds;
            float yVelocity = y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaX = vector.X + xVelocity;
            float deltaY = vector.Y + yVelocity;

            return new Vector2(deltaX, deltaY);
        }
        public static Vector2 MoveX(this Vector2 vector, float x, GameTime gameTime)
        {
            float xVelocity = x * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaX = vector.X + xVelocity;

            return new Vector2(deltaX, vector.Y);
        }
        public static Vector2 MoveY(this Vector2 vector, float y, GameTime gameTime)
        {
            float yVelocity = y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaY = vector.Y + yVelocity;

            return new Vector2(vector.X, deltaY);
        }

        public static Vector3 ToVector3(this Vector2 v) => new Vector3(v.X, v.Y, 0);
        public static Vector3 ToVector3(this Point p) => new Vector3(p.X, p.Y, 0);

        public static Vector2 ToVector2(this Vector3 v) => new Vector2(v.X, v.Y);


    }
}