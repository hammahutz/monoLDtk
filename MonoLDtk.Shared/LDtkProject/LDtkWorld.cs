
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject.Data;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkWorld
{
    internal string Identifier { get; private set; }
    internal Guid Iid { get; private set; }

    internal List<LDtkLevel> Levels { get; private set; }
    internal int CurrentLevel { get; private set; } = 0;

    internal LDtkWorld(World world, GameAssetsManager content)
    {
        Identifier = world.Identifier;
        Iid = world.Iid;

        Levels = world.Levels
            .Select(l => new LDtkLevel(l, content))
            .OrderBy(l => l.WorldDepth)
            .ToList();
    }

    internal void Draw(SpriteBatch spriteBatch) => Levels.ForEach(l => l.Draw(spriteBatch));
}
