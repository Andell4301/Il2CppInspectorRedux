using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppMethodSpecOnGenericType
{
    public MethodIndex MethodDefinitionIndex;
    public GenericInstIndex ClassIndexIndex;
}