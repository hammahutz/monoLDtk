
using Microsoft.Xna.Framework;

namespace MonoLDtk.Shared
{
    public static class Extension
    {
        public static Vector2 Move(this Vector2 vector, float x, float y, GameTime gameTime)
        {
            float xVelocity  = x * (float)gameTime.ElapsedGameTime.TotalSeconds;
            float yVelocity  = y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaX = vector.X + xVelocity;
            float deltaY = vector.Y + yVelocity;

            return new Vector2(deltaX, deltaY);
        }
        public static Vector2 MoveX(this Vector2 vector, float x, GameTime gameTime)
        {
            float xVelocity  = x * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaX = vector.X + xVelocity;

            return new Vector2(deltaX, vector.Y);
        }
        public static Vector2 MoveY(this Vector2 vector, float y, GameTime gameTime)
        {
            float yVelocity  = y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            float deltaY = vector.Y + yVelocity;

            return new Vector2(vector.X, deltaY);
        }


    }
}