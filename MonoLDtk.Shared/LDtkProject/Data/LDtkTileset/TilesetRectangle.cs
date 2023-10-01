using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

internal class TilesetRectangle
{
  /// <summary>
        /// Height in pixels
        /// </summary>
        [JsonProperty("h")]
        internal long H { get; set; }

        /// <summary>
        /// UID of the tileset
        /// </summary>
        [JsonProperty("tilesetUid")]
        internal long TilesetUid { get; set; }

        /// <summary>
        /// Width in pixels
        /// </summary>
        [JsonProperty("w")]
        internal long W { get; set; }

        /// <summary>
        /// X pixels coordinate of the top-left corner in the Tileset image
        /// </summary>
        [JsonProperty("x")]
        internal long X { get; set; }

        /// <summary>
        /// Y pixels coordinate of the top-left corner in the Tileset image
        /// </summary>
        [JsonProperty("y")]
        internal long Y { get; set; }
}
