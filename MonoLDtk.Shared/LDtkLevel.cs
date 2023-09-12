using MonoLDtk.Shared.LDtkProject.LDtkInstance;
using MonoLDtk.Shared.LDtkProject.LDtkLevel;

namespace MonoLDtk.Shared;

public class LDtkLevel
{
    public string Identifier { get; private set; }
    public Guid Iid { get; private set; }
    public LDtkLayer[] Layers { get; private set; }
    public LDtkLayerType Type { get; private set; }

    internal LDtkLevel(Level level)
    {
        Identifier = level.Identifier;
        Iid = level.Iid;
        Layers = level.LayerInstances
        .Select(li => new LDtkLayer(li))
        .ToArray(); 
    }
}
