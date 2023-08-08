using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject.LDtkDefinitions;

internal class LayerDefinition
{
        /// <summary>
        /// Type of the layer (*IntGrid, Entities, Tiles or AutoLayer*)
        /// </summary>
        [JsonProperty("__type")]
        internal string Type { get; set; }

        /// <summary>
        /// Contains all the auto-layer rule definitions.
        /// </summary>
        [JsonProperty("autoRuleGroups")]
        internal AutoLayerRuleGroup[] AutoRuleGroups { get; set; }

        [JsonProperty("autoSourceLayerDefUid")]
        internal long? AutoSourceLayerDefUid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
        /// by: `tilesetDefUid`
        /// </summary>
        [JsonProperty("autoTilesetDefUid")]
        internal long? AutoTilesetDefUid { get; set; }

        /// <summary>
        /// Allow editor selections when the layer is not currently active.
        /// </summary>
        [JsonProperty("canSelectWhenInactive")]
        internal bool CanSelectWhenInactive { get; set; }

        /// <summary>
        /// Opacity of the layer (0 to 1.0)
        /// </summary>
        [JsonProperty("displayOpacity")]
        internal double DisplayOpacity { get; set; }

        /// <summary>
        /// User defined documentation for this element to provide help/tips to level designers.
        /// </summary>
        [JsonProperty("doc")]
        internal string Doc { get; set; }

        /// <summary>
        /// An array of tags to forbid some Entities in this layer
        /// </summary>
        [JsonProperty("excludedTags")]
        internal string[] ExcludedTags { get; set; }

        /// <summary>
        /// Width and height of the grid in pixels
        /// </summary>
        [JsonProperty("gridSize")]
        internal long GridSize { get; set; }

        /// <summary>
        /// Height of the optional "guide" grid in pixels
        /// </summary>
        [JsonProperty("guideGridHei")]
        internal long GuideGridHei { get; set; }

        /// <summary>
        /// Width of the optional "guide" grid in pixels
        /// </summary>
        [JsonProperty("guideGridWid")]
        internal long GuideGridWid { get; set; }

        [JsonProperty("hideFieldsWhenInactive")]
        internal bool HideFieldsWhenInactive { get; set; }

        /// <summary>
        /// Hide the layer from the list on the side of the editor view.
        /// </summary>
        [JsonProperty("hideInList")]
        internal bool HideInList { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonProperty("identifier")]
        internal string Identifier { get; set; }

        /// <summary>
        /// Alpha of this layer when it is not the active one.
        /// </summary>
        [JsonProperty("inactiveOpacity")]
        internal double InactiveOpacity { get; set; }

        /// <summary>
        /// An array that defines extra optional info for each IntGrid value.<br/>  WARNING: the
        /// array order is not related to actual IntGrid values! As user can re-order IntGrid values
        /// freely, you may value "2" before value "1" in this array.
        /// </summary>
        [JsonProperty("intGridValues")]
        internal IntGridValueDefinition[] IntGridValues { get; set; }

        /// <summary>
        /// Parallax horizontal factor (from -1 to 1, defaults to 0) which affects the scrolling
        /// speed of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonProperty("parallaxFactorX")]
        internal double ParallaxFactorX { get; set; }

        /// <summary>
        /// Parallax vertical factor (from -1 to 1, defaults to 0) which affects the scrolling speed
        /// of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonProperty("parallaxFactorY")]
        internal double ParallaxFactorY { get; set; }

        /// <summary>
        /// If true (default), a layer with a parallax factor will also be scaled up/down accordingly.
        /// </summary>
        [JsonProperty("parallaxScaling")]
        internal bool ParallaxScaling { get; set; }

        /// <summary>
        /// X offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonProperty("pxOffsetX")]
        internal long PxOffsetX { get; set; }

        /// <summary>
        /// Y offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonProperty("pxOffsetY")]
        internal long PxOffsetY { get; set; }

        /// <summary>
        /// If TRUE, the content of this layer will be used when rendering levels in a simplified way
        /// for the world view
        /// </summary>
        [JsonProperty("renderInWorldView")]
        internal bool RenderInWorldView { get; set; }

        /// <summary>
        /// An array of tags to filter Entities that can be added to this layer
        /// </summary>
        [JsonProperty("requiredTags")]
        internal string[] RequiredTags { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonProperty("tilePivotX")]
        internal double TilePivotX { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonProperty("tilePivotY")]
        internal double TilePivotY { get; set; }

        /// <summary>
        /// Reference to the default Tileset UID being used by this layer definition.<br/>
        /// **WARNING**: some layer *instances* might use a different tileset. So most of the time,
        /// you should probably use the `__tilesetDefUid` value found in layer instances.<br/>  Note:
        /// since version 1.0.0, the old `autoTilesetDefUid` was removed and merged into this value.
        /// </summary>
        [JsonProperty("tilesetDefUid")]
        internal long? TilesetDefUid { get; set; }

        /// <summary>
        /// Type of the layer as Haxe Enum Possible values: `IntGrid`, `Entities`, `Tiles`,
        /// `AutoLayer`
        /// </summary>
        [JsonProperty("type")]
        internal TypeEnum LayerDefinitionType { get; set; }

        /// <summary>
        /// User defined color for the UI
        /// </summary>
        [JsonProperty("uiColor")]
        internal string UiColor { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonProperty("uid")]
        internal long Uid { get; set; }
}
