﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppTypeDefinitionBitfield
{
    private uint _value;

    public bool ValueType => ((_value >> 0) & 1) == 1;
    public bool EnumType => ((_value >> 1) & 1) == 1;
    public bool HasFinalize => ((_value >> 2) & 1) == 1;
    public bool HasCctor => ((_value >> 3) & 1) == 1;
    public bool IsBlittable => ((_value >> 4) & 1) == 1;
    public bool IsImportOrWindowsRuntime => ((_value >> 5) & 1) == 1;
    public PackingSize PackingSize => (PackingSize)((_value >> 6) & 0b1111);
    public bool DefaultPackingSize => ((_value >> 10) & 1) == 1;
    public bool DefaultClassSize => ((_value >> 11) & 1) == 1;
    public PackingSize ClassSize => (PackingSize)((_value >> 12) & 0b1111);
    public bool IsByRefLike => ((_value >> 13) & 1) == 1;
}