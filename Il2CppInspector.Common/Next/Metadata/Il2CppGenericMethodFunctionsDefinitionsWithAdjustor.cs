using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppGenericMethodFunctionsDefinitionsWithAdjustor
{
    public GenericMethodIndex GenericMethodIndex;
    public MethodPointerTableIndex MethodIndex;
    public InvokerTableIndex InvokerIndex;
    public AdjustorThunkIndex AdjustorThunkIndex;
}