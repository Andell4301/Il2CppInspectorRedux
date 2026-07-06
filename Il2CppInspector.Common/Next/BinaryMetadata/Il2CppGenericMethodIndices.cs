using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.BinaryMetadata;

[VersionedStruct]
public partial record struct Il2CppGenericMethodIndices
{
    public MethodPointerTableIndex MethodIndex;
    public InvokerTableIndex InvokerIndex;

    [VersionCondition(EqualTo = "24.5")]
    [VersionCondition(GreaterThanOrEqual = "27.1", LessThan = "108.0")]
    public MethodIndex AdjustorThunkIndex;
}