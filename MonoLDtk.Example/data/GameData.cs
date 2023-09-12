using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonoLDtk.Example.data;

using Newtonsoft.Json.Serialization;

namespace MonoLDtk.Example;

public static class GameData
{
    public static GameWorld World1 = new GameWorld(new Guid("b9b978f0-1460-11ee-963b-69bd464994f8"));
}
