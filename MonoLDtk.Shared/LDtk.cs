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
    public Dictionary<long, LDtkTileset> Tilesets { get; private set; } = new Dictionary<long, LDtkTileset>();

    public LDtk() => LDtkData = new LDtkData();
    public LDtk(string ldtkData) => SetLDtkData(ldtkData);


    public override string ToString() => JSON;
    public void SetLDtkData(string ldtkData) => LDtkData = JsonConvert.DeserializeObject<LDtkData>(ldtkData) ?? new LDtkData();

    public void LoadContent(ContentManager content)
    {
        Tilesets = LDtkData.Defs.Tilesets
        .Select(x => new LDtkTileset(x.Uid, x.RelPath, content))
        .ToDictionary(y => y.Id);

        
    }

    public void Draw(SpriteBatch spriteBatch) => spriteBatch.Draw(Tilesets[8].Texture, Vector2.Zero, Color.White);
}