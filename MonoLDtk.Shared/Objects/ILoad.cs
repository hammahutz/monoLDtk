using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoLDtk.Shared.GameObjects
{
    public interface ILoad
    {
        public void Load(GameAssetsManager gameAssetsManager);
        public void Unload();
    }
}