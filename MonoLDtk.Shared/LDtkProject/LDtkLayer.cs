using System.Collections.Specialized;
using System.Net.Mail;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkLayer
{

    public Guid Iid { get; set; }
    public long? TilesetDefUid { get; set; }
    public string TilesetRelPath { get; set; }
    public string Type { get; set; } = LDtkLayerType.None;
    public Texture2D TileSheet { get; set; }

    public List<LDtkTile> Tiles { get; set; }

    internal LDtkLayer(LayerInstance layerInstance, ContentManager content, Vector2 worldPosition)
    {
        Iid = layerInstance.Iid;
        TilesetDefUid = layerInstance.TilesetDefUid;
        Type = layerInstance.Type;


        if (layerInstance.TilesetRelPath != null)
        {
            TilesetRelPath = FormatRelativePath(layerInstance.TilesetRelPath) ?? "";
            LoadTileSheet(content);
            LoadTiles(layerInstance, worldPosition);
        }
    }

    private void LoadTiles(LayerInstance layerInstance, Vector2 worldPosition)
    {
        Tiles = layerInstance.AutoLayerTiles
        .Select(t => new LDtkTile(t, (int)layerInstance.GridSize, worldPosition))
        .ToList();
    }

    private string FormatRelativePath(string relPath)
    {
        int textureIndex = relPath.IndexOf("Texture");
        int filetypeIndex = relPath.LastIndexOf(".");

        return relPath.Substring(textureIndex, filetypeIndex - textureIndex);
    }

    internal void LoadTileSheet(ContentManager content)
    {
        if (Type == LDtkLayerType.AutoLayer || Type == LDtkLayerType.Tiles)
        {
            TileSheet = content.Load<Texture2D>(TilesetRelPath);
        }
    }

    internal void Draw(SpriteBatch spriteBatch)
    {
        if (TileSheet == null)
            return;

        Tiles.ForEach(t => t.Draw(TileSheet, spriteBatch));
    }
}