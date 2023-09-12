using System.Diagnostics;

using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared;
using MonoLDtk.Shared.LDtkProject;

namespace MonoLDtk.Shared;

public class LDtkWorld
{
    public string Identifier { get; private set; }
    public Guid Iid { get; private set; }

    public LDtkLevel[] Levels { get; private set; }
    public int CurrentLevel { get; private set; }

    internal LDtkWorld(World world)
    {
        Identifier = world.Identifier;
        Iid = world.Iid;

        Levels = world.Levels
        .Select(l => new LDtkLevel(l))
        .ToArray();
    }

    public void Draw(SpriteBatch spriteBatch){

    }
}
