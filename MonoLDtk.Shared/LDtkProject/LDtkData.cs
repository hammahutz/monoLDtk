﻿using MonoLDtk.Shared.LDtkProject.LDtkDefinitions;
using MonoLDtk.Shared.LDtkProject.LDtkLevel;

using Newtonsoft.Json;

namespace MonoLDtk.Shared.LDtkProject;

internal class LDtkData
{
    /// <summary>
    /// LDtk application build identifier.<br/>  This is only used to identify the LDtk version
    /// that generated this particular project file, which can be useful for specific bug fixing.
    /// Note that the build identifier is just the date of the release, so it's not unique to
    /// each user (one single global ID per LDtk internal release), and as a result, completely
    /// anonymous.
    /// </summary>
    [JsonProperty("appBuildId")]
    internal double AppBuildId { get; set; }

    /// <summary>
    /// Number of backup files to keep, if the `backupOnSave` is TRUE
    /// </summary>
    [JsonProperty("backupLimit")]
    internal long BackupLimit { get; set; }

    /// <summary>
    /// If TRUE, an extra copy of the project will be created in a sub folder, when saving.
    /// </summary>
    [JsonProperty("backupOnSave")]
    internal bool BackupOnSave { get; set; }

    /// <summary>
    /// Target relative path to store backup files
    /// </summary>
    [JsonProperty("backupRelPath")]
    internal string BackupRelPath { get; set; }

    /// <summary>
    /// Project background color
    /// </summary>
    [JsonProperty("bgColor")]
    internal string BgColor { get; set; }

    /// <summary>
    /// An array of command lines that can be ran manually by the user
    /// </summary>
    [JsonProperty("customCommands")]
    internal LdtkCustomCommand[] CustomCommands { get; set; }

    /// <summary>
    /// Default grid size for new layers
    /// </summary>
    [JsonProperty("defaultGridSize")]
    internal long DefaultGridSize { get; set; }

    /// <summary>
    /// Default background color of levels
    /// </summary>
    [JsonProperty("defaultLevelBgColor")]
    internal string DefaultLevelBgColor { get; set; }

    /// <summary>
    /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
    /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
    /// the change immediately.<br/><br/>  Default new level height
    /// </summary>
    [JsonProperty("defaultLevelHeight")]
    internal long? DefaultLevelHeight { get; set; }

    /// <summary>
    /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
    /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
    /// the change immediately.<br/><br/>  Default new level width
    /// </summary>
    [JsonProperty("defaultLevelWidth")]
    internal long? DefaultLevelWidth { get; set; }

    /// <summary>
    /// Default X pivot (0 to 1) for new entities
    /// </summary>
    [JsonProperty("defaultPivotX")]
    internal double DefaultPivotX { get; set; }

    /// <summary>
    /// Default Y pivot (0 to 1) for new entities
    /// </summary>
    [JsonProperty("defaultPivotY")]
    internal double DefaultPivotY { get; set; }

    /// <summary>
    /// A structure containing all the definitions of this project
    /// </summary>
    [JsonProperty("defs")]
    internal Definitions Defs { get; set; }

    /// <summary>
    /// If the project isn't in MultiWorlds mode, this is the IID of the internal "dummy" World.
    /// </summary>
    [JsonProperty("dummyWorldIid")]
    internal Guid DummyWorldIid { get; set; }

    /// <summary>
    /// If TRUE, the exported PNGs will include the level background (color or image).
    /// </summary>
    [JsonProperty("exportLevelBg")]
    internal bool ExportLevelBg { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value is no longer exported since version 0.9.3  Replaced
    /// by: `imageExportMode`
    /// </summary>
    [JsonProperty("exportPng")]
    internal bool? ExportPng { get; set; }

    /// <summary>
    /// If TRUE, a Tiled compatible file will also be generated along with the LDtk JSON file
    /// (default is FALSE)
    /// </summary>
    [JsonProperty("exportTiled")]
    internal bool ExportTiled { get; set; }

    /// <summary>
    /// If TRUE, one file will be saved for the project (incl. all its definitions) and one file
    /// in a sub-folder for each level.
    /// </summary>
    [JsonProperty("externalLevels")]
    internal bool ExternalLevels { get; set; }

    /// <summary>
    /// An array containing various advanced flags (ie. options or other states). Possible
    /// values: `DiscardPreCsvIntGrid`, `ExportPreCsvIntGridFormat`, `IgnoreBackupSuggest`,
    /// `PrependIndexToLevelFileNames`, `MultiWorlds`, `UseMultilinesType`
    /// </summary>
    [JsonProperty("flags")]
    internal Flag[] Flags { get; set; }

    /// <summary>
    /// Naming convention for Identifiers (first-letter uppercase, full uppercase etc.) Possible
    /// values: `Capitalize`, `Uppercase`, `Lowercase`, `Free`
    /// </summary>
    [JsonProperty("identifierStyle")]
    internal IdentifierStyle IdentifierStyle { get; set; }

    /// <summary>
    /// Unique project identifier
    /// </summary>
    [JsonProperty("iid")]
    internal Guid Iid { get; set; }

    /// <summary>
    /// "Image export" option when saving project. Possible values: `None`, `OneImagePerLayer`,
    /// `OneImagePerLevel`, `LayersAndLevels`
    /// </summary>
    [JsonProperty("imageExportMode")]
    internal ImageExportMode ImageExportMode { get; set; }

    /// <summary>
    /// File format version
    /// </summary>
    [JsonProperty("jsonVersion")]
    internal string JsonVersion { get; set; }

    /// <summary>
    /// The default naming convention for level identifiers.
    /// </summary>
    [JsonProperty("levelNamePattern")]
    internal string LevelNamePattern { get; set; }

    /// <summary>
    /// All levels. The order of this array is only relevant in `LinearHorizontal` and
    /// `linearVertical` world layouts (see `worldLayout` value).<br/>  Otherwise, you should
    /// refer to the `worldX`,`worldY` coordinates of each Level.
    /// </summary>
    [JsonProperty("levels")]
    internal Level[] Levels { get; set; }

    /// <summary>
    /// If TRUE, the Json is partially minified (no indentation, nor line breaks, default is
    /// FALSE)
    /// </summary>
    [JsonProperty("minifyJson")]
    internal bool MinifyJson { get; set; }

    /// <summary>
    /// Next Unique integer ID available
    /// </summary>
    [JsonProperty("nextUid")]
    internal long NextUid { get; set; }

    /// <summary>
    /// File naming pattern for exported PNGs
    /// </summary>
    [JsonProperty("pngFilePattern")]
    internal string PngFilePattern { get; set; }

    /// <summary>
    /// If TRUE, a very simplified will be generated on saving, for quicker & easier engine
    /// integration.
    /// </summary>
    [JsonProperty("simplifiedExport")]
    internal bool SimplifiedExport { get; set; }

    /// <summary>
    /// All instances of entities that have their `exportToToc` flag enabled are listed in this
    /// array.
    /// </summary>
    [JsonProperty("toc")]
    internal LdtkTableOfContentEntry[] Toc { get; set; }

    /// <summary>
    /// This optional description is used by LDtk Samples to show up some informations and
    /// instructions.
    /// </summary>
    [JsonProperty("tutorialDesc")]
    internal string TutorialDesc { get; set; }

    /// <summary>
    /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
    /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
    /// the change immediately.<br/><br/>  Height of the world grid in pixels.
    /// </summary>
    [JsonProperty("worldGridHeight")]
    internal long? WorldGridHeight { get; set; }

    /// <summary>
    /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
    /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
    /// the change immediately.<br/><br/>  Width of the world grid in pixels.
    /// </summary>
    [JsonProperty("worldGridWidth")]
    internal long? WorldGridWidth { get; set; }

    /// <summary>
    /// **WARNING**: this field will move to the `worlds` array after the "multi-worlds" update.
    /// It will then be `null`. You can enable the Multi-worlds advanced project option to enable
    /// the change immediately.<br/><br/>  An enum that describes how levels are organized in
    /// this project (ie. linearly or in a 2D space). Possible values: &lt;`null`&gt;, `Free`,
    /// `GridVania`, `LinearHorizontal`, `LinearVertical`
    /// </summary>
    [JsonProperty("worldLayout")]
    internal WorldLayout? WorldLayout { get; set; }

    /// <summary>
    /// This array will be empty, unless you enable the Multi-Worlds in the project advanced
    /// settings.<br/><br/> - in current version, a LDtk project file can only contain a single
    /// world with multiple levels in it. In this case, levels and world layout related settings
    /// are stored in the root of the JSON.<br/> - with "Multi-worlds" enabled, there will be a
    /// `worlds` array in root, each world containing levels and layout settings. Basically, it's
    /// pretty much only about moving the `levels` array to the `worlds` array, along with world
    /// layout related values (eg. `worldGridWidth` etc).<br/><br/>If you want to start
    /// supporting this future update easily, please refer to this documentation:
    /// https://github.com/deepnight/ldtk/issues/231
    /// </summary>
    [JsonProperty("worlds")]
    internal World[] Worlds { get; set; }
}
