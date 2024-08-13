﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppMetadataUsagePair
{
    public uint DestinationIndex { get; private set; }
    public uint EncodedSourceIndex { get; private set; }
}