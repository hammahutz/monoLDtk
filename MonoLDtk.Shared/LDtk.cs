using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

using Newtonsoft.Json;

using MonoLDtk.Shared.LDtkProject;


namespace MonoLDtk.Shared;
public class LDtk
{
    internal LDtkData LDtkData;

    public string JSON => JsonConvert.SerializeObject(LDtkData) ?? "{}";
    public override string ToString() => JSON;

    public Dictionary<long, LDtkTileset> Tilesets { get; private set; } = new Dictionary<long, LDtkTileset>();
    public Dictionary<string, LDtkWorld> Worlds { get; private set; }

    public LDtk() => LDtkData = new LDtkData();
    public LDtk(string ldtkData) => SetLDtkData(ldtkData);

    public void SetLDtkData(string ldtkData) => LDtkData = JsonConvert.DeserializeObject<LDtkData>(ldtkData) ?? new LDtkData();

    public void LoadWorld(ContentManager content)
    {
        Tilesets = LDtkData.Defs.Tilesets
        .Select(x => new LDtkTileset(x.Uid, x.RelPath, content))
        .ToDictionary(y => y.Id);

        Worlds = LDtkData.Worlds
        .Select(w => new LDtkWorld(w))
        .ToDictionary(w => w.Identifier);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Worlds[world].Draw(spriteBatch);
    }
}