﻿using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.BinaryMetadata;

using PInvokeMarshalToNativeFunc = Il2CppMethodPointer;
using PInvokeMarshalFromNativeFunc = Il2CppMethodPointer;
using PInvokeMarshalCleanupFunc = Il2CppMethodPointer;
using CreateCCWFunc = Il2CppMethodPointer;

[VersionedStruct]
public partial struct Il2CppInteropData
{
    public Il2CppMethodPointer DelegatePInvokeWrapperFunction;
    public PInvokeMarshalToNativeFunc PInvokeMarshalToNativeFunction;
    public PInvokeMarshalFromNativeFunc PInvokeMarshalFromNativeFunction;
    public PInvokeMarshalCleanupFunc PInvokeMarshalCleanupFunction;
    public CreateCCWFunc CreateCCWFunction;
    public Pointer<Il2CppGuid> Guid;
    public Pointer<Il2CppType> Type;
}