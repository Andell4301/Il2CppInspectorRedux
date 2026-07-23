using VersionedSerialization.Attributes;

namespace Il2CppInspector.Next.Metadata;

[VersionedStruct]
public partial struct Il2CppGeneratedMethodTypeInfo
{
    public TypeDefinitionIndex TypeIndex { get; private set; }
    public MethodIndex GeneratedMethodStart { get; private set; }
    public int GeneratedMethodCount { get; private set; }
}