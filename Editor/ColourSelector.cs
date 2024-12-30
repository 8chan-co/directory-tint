using HarmonyLib;
using System;
using System.Reflection;
using UnityEngine;

namespace Ophura
{
    internal static class ColourSelector
    {
        internal static readonly Type ColorPicker;
        private static readonly MethodInfo ShowFunction;
        private static readonly object[] Arguments = { null, null, true, false };

        static ColourSelector()
        {
            ColorPicker = AccessTools.TypeByName(Consistent.ColorPickerFullTypeName);

            Type[] Signature = { typeof(Action<Color>), typeof(Color), typeof(bool), typeof(bool) };

            ShowFunction = AccessTools.Method(type: ColorPicker, name: nameof(Show), parameters: Signature);
        }

        internal static void Show(Action<Color> Operation, Color InitialColour)
        {
            Arguments[0] = Operation;
            Arguments[1] = InitialColour;

            ShowFunction.Invoke(obj: null, parameters: Arguments);
        }

        internal static void OnDestroy() => ColourStorage.instance.Lodge();
    }
}