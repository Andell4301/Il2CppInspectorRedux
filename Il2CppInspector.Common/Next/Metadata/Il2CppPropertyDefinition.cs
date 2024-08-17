﻿using System.Reflection;
using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

using StringIndex = int;
using MethodIndex = int;

[VersionedStruct]
public partial record struct Il2CppPropertyDefinition
{
    public StringIndex NameIndex { get; private set; }
    public MethodIndex Get { get; private set; }
    public MethodIndex Set { get; private set; }
    public PropertyAttributes Attrs { get; private set; }

    [VersionCondition(LessThan = "24.0")]
    public int CustomAttributeIndex { get; private set; }

    [VersionCondition(GreaterThan = "19.0")]
    public uint Token { get; private set; }

    public readonly bool IsValid => NameIndex != 0;
}