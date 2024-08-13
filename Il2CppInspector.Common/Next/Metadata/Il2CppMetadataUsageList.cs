﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppMetadataUsageList
{
    public int Start { get; private set; }
    public int Count { get; private set; }
}