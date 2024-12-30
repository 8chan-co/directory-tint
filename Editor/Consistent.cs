using UnityEngine;

namespace Ophura
{
    internal static partial class Consistent
    {
        internal const string ColourStoragePathname = "DirectoryColour/ColoursStorage.llama";
        private const string FeaturesRoot = "Assets/Ophélia/";

        internal const string EditorPatchingIdentifier = "com.ophura.directory-colour";
        internal const string ColorPickerFullTypeName = "UnityEditor.ColorPicker";

        private const int PrecedenceOrigin = 1200;
        internal const int ContextMicePress = 1;
        internal const int ColouriseDirectoryPrecedence = PrecedenceOrigin + 0;
        internal const int SuppressColourPrecedence = PrecedenceOrigin + 1;
        internal const int ListEffectiveDirectoriesPrecedence = PrecedenceOrigin + 12;
    }

    internal static partial class Consistent
    {
        internal const string ColouriseDirectoryLabel = "Colourise Directory";
        internal const string ColouriseDirectoryFeature = FeaturesRoot + ColouriseDirectoryLabel;

        internal const string SuppressColourLabel = "SuppressColour";
        internal const string SuppressColourFeature = FeaturesRoot + SuppressColourLabel;

        internal const string ListEffectiveDirectoriesLabel = "List Effective Directories";
        internal const string EffectiveDirectoriesFeature = FeaturesRoot + ListEffectiveDirectoriesLabel;
    }

    internal static partial class Consistent
    {
        internal static readonly Color PureDirectoryColour = new Color32(r: 194, g: 194, b: 194, a: byte.MaxValue);
    }
}
