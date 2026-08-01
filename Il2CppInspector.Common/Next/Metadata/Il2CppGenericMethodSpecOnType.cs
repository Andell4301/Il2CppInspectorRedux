using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppGenericMethodSpecOnType
{
    public MethodIndex MethodDefinitionIndex;
    public GenericInstIndex MethodIndexIndex;
}