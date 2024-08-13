﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.BinaryMetadata;

using GenericMethodIndex = int;

[VersionedStruct]
public partial struct Il2CppGenericMethodFunctionsDefinitions
{
    public GenericMethodIndex GenericMethodIndex;
    public Il2CppGenericMethodIndices Indices;
}