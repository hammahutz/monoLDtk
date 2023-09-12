using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoLDtk.Example.data;

public class GameWorld
{
    public Guid Guid { get; set; }
    public GameLevel[] GameLevels { get; set; }
    public GameWorld(Guid guid)
    {
        Guid = guid;
    }
}
