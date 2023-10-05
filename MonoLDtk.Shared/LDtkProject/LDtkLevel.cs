using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.GameObjects;
using MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;
using MonoLDtk.Shared.LDtkProject.Data.LDtkLevel;

namespace MonoLDtk.Shared.LDtkProject;

internal class LDtkLevel
{
    internal string Identifier { get; private set; }
    internal Guid Iid { get; private set; }

    internal Vector2 WorldPosition;

    public long WorldDepth { get; private set; }
    internal List<LDtkLayer> Layers { get; private set; }

    internal LDtkLevel(Level level, GameAssetsManager content)
    {
        Identifier = level.Identifier;
        Iid = level.Iid;
        WorldPosition = new Vector2(level.WorldX, level.WorldY);
        WorldDepth = level.WorldDepth;

        Layers = level.LayerInstances
        .Select(li => new LDtkLayer(li, content, WorldPosition))
        .ToList();
    }

    internal void Draw(SpriteBatch spritebatch) => Layers.ForEach(l => l.Draw(spritebatch));
}
