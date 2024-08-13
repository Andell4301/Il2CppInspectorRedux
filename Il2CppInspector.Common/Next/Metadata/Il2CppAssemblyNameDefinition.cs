﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

using StringIndex = int;

[InlineArray(PublicKeyLength)]
public struct PublicKeyToken
{
    private const int PublicKeyLength = 8;

    private byte _value;
}

[VersionedStruct]
[StructLayout(LayoutKind.Explicit)]
public partial struct Il2CppAssemblyNameDefinition
{
    [FieldOffset(0)]
    public StringIndex NameIndex;

    [FieldOffset(4)]
    public StringIndex CultureIndex;

    [FieldOffset(8)]
    [VersionCondition(LessThan = "24.3")]
    public int HashValueIndex;

    [FieldOffset(12)]
    public StringIndex PublicKeyIndex;

    [FieldOffset(44)]
    [VersionCondition(LessThan = "15.0")]
    [CustomSerialization("reader.Read<PublicKeyToken>();", "8")]
    private PublicKeyToken _legacyPublicKeyToken;

    [FieldOffset(16)]
    public AssemblyHashAlgorithm HashAlg;

    [FieldOffset(20)]
    public int HashLen;

    [FieldOffset(24)]
    public AssemblyNameFlags Flags;

    [FieldOffset(28)]
    public int Major;

    [FieldOffset(32)]
    public int Minor;

    [FieldOffset(36)]
    public int Build;

    [FieldOffset(40)]
    public int Revision;

    [FieldOffset(44)]
    [CustomSerialization("reader.Read<PublicKeyToken>();", "8")]
    public PublicKeyToken PublicKeyToken;
}