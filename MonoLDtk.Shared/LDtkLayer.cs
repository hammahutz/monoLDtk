using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.LDtkProject.LDtkInstance;

namespace MonoLDtk.Shared;

public class LDtkLayer
{
    internal LDtkLayer(LayerInstance layerInstance)
    {
        Iid = layerInstance.Iid;
        TilesetDefUid = layerInstance.TilesetDefUid;
        TilesetRelPath = layerInstance.TilesetRelPath;
        Type = layerInstance.Type;
       

        switch (type){
            case LDtkLayerType.None:
                break;
                case LDtkLayerType.IntGrid:
            break;
        }
    }

    public Guid Iid { get; set; }
    public long TilesetDefUid { get; set; }
    public string TilesetRelPath { get; set; }
    public string Type { get; set; } = LDtkLayerType.None;

    public LDtkTile[] Tiles { get; set; }

    internal void LoadTile()
    {

    }

    internal void Draw(SpriteBatch spriteBatch)
    {
    }
}