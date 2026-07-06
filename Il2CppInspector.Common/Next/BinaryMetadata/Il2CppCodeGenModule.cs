using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.BinaryMetadata;

[VersionedStruct]
public partial record struct Il2CppCodeGenModule
{
    public PrimitivePointer<byte> ModuleName; // const char*

    [NativeInteger]
    public uint MethodPointerCount;
    
    public Pointer<Il2CppMethodPointer> MethodPointers;

    [NativeInteger]
    [VersionCondition(EqualTo = "24.5")]
    [VersionCondition(GreaterThanOrEqual = "27.1")]
    public uint AdjustorThunksCount;

    [VersionCondition(EqualTo = "24.5")]
    [VersionCondition(GreaterThanOrEqual = "27.1")]
    public Pointer<Il2CppTokenAdjustorThunkPair> AdjustorThunks;

    [VersionCondition(LessThan = "108.0")]
    public PrimitivePointer<int> InvokerIndices; // int*

    [NativeInteger]
    public uint ReversePInvokeWrapperCount;

    public Pointer<Il2CppTokenIndexMethodTuple> ReversePInvokeWrapperIndices;

    [VersionCondition(LessThan = "108.0")]
    [NativeInteger]
    public uint RgctxRangesCount;

    [VersionCondition(LessThan = "108.0")]
    public Pointer<Il2CppTokenRangePair> RgctxRanges;

    [VersionCondition(LessThan = "108.0")]
    [NativeInteger]
    public uint RgctxsCount;

    [VersionCondition(LessThan = "108.0")]
    public Pointer<Il2CppRgctxDefinition> Rgctxs;

    public PrimitivePointer<byte> DebuggerMetadata; // Pointer<Il2CppDebuggerMetadataRegistration> DebuggerMetadata;

    [VersionCondition(GreaterThanOrEqual = "27.0", LessThanOrEqual = "27.2")]
    public Pointer<Il2CppMethodPointer> CustomAttributeCacheGenerator;

    [VersionCondition(GreaterThanOrEqual = "27.0")]
    public Il2CppMethodPointer ModuleInitializer;

    [VersionCondition(GreaterThanOrEqual = "27.0", LessThan = "108.0")]
    public PrimitivePointer<int> StaticConstructorTypeIndices; // TypeDefinitionIndex*

    [VersionCondition(GreaterThanOrEqual = "27.0")]
    public PrimitivePointer<byte> MetadataRegistration; // Pointer<Il2CppMetadataRegistration>

    [VersionCondition(GreaterThanOrEqual = "27.0")]
    public PrimitivePointer<byte> CodeRegistration; // Pointer<Il2CppCodeRegistration>
}