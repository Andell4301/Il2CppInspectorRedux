using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppGenericMethodFunctionsDefinitionsWithAdjustor
{
    public GenericMethodIndex GenericMethodIndex;
    public MethodIndex MethodIndex;
    public MethodIndex InvokerIndex;
    public MethodIndex AdjustorThunkIndex;
}