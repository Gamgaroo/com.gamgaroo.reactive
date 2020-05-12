﻿using Gamgaroo.Reactive.Runtime.Serializable.Primitives;
using UnityEditor;

namespace Gamgaroo.Reactive.Editor.Primitives
{
    [CustomPropertyDrawer(typeof(ReactiveBool))]
    public sealed class ReactiveBoolPropertyDrawer : SerializableReactivePropertyDrawer
    {
    }
}