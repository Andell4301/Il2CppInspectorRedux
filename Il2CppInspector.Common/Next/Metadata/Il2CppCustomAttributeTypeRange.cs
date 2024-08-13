﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppCustomAttributeTypeRange
{
    [VersionCondition(GreaterThan = "24.1")]
    public uint Token { get; private set; }

    public int Start { get; private set; }
    public int Count { get; private set; }
}