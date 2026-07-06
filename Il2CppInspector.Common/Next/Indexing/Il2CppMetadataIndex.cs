using System.Diagnostics;
using System.Runtime.CompilerServices;
using VersionedSerialization;

namespace Il2CppInspector.Next.Indexing;

file static class Il2CppMetadataIndex
{
    public const int Invalid = -1;
    public const char NumberZeroChar = '0';
}

public struct Il2CppMetadataIndex<T>(int value) : IReadable, IEquatable<Il2CppMetadataIndex<T>>
{
    public int Value { get; private set; } = value;

    public static readonly string TagPrefix = $"{typeof(T).Name}";

    public static readonly string SizeTag = $"{typeof(T).Name}Size";

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetSizeFromTag(in StructVersion version)
    {
        // Fallback to the default for unsupported configurations.
        if (version < MetadataVersions.V380 || version.Tag == null)
        {
            return sizeof(int);
        }

        // Get the position of the size tag in the version tag.
        // Bail out if not found.
        var sizeTagPosition = version.Tag.IndexOf(SizeTag, StringComparison.Ordinal);
        if (sizeTagPosition == -1)
        {
            return sizeof(int);
        }

        // Get the number that follows immediately after the size tag, and convert it to the actual size.
        var numberChar = version.Tag[sizeTagPosition + SizeTag.Length];
        return numberChar - Il2CppMetadataIndex.NumberZeroChar;
    }

    public static string CreateTagBySize(int size)
    {
        Debug.Assert(size is sizeof(byte) or sizeof(ushort) or sizeof(uint));
        return $"{SizeTag}{size}";
    }

    public static int GetSizeByCount(int count) => count switch
    {
        < byte.MaxValue => sizeof(byte),
        < ushort.MaxValue => sizeof(ushort),
        _ => sizeof(uint)
    };

    public static string CreateTagByCount(int count)
        => CreateTagBySize(GetSizeByCount(count));

    void IReadable.Read<TReader>(ref Reader<TReader> reader, in StructVersion version)
    {
        var size = GetSizeFromTag(in version);

        if (size == sizeof(int))
        {
            Value = reader.ReadPrimitive<int>();
        }
        else if (size == sizeof(ushort))
        {
            var value = reader.ReadPrimitive<ushort>();
            Value = value == ushort.MaxValue ? Il2CppMetadataIndex.Invalid : value;
        }
        else
        {
            Debug.Assert(size == sizeof(byte));

            var value = reader.ReadPrimitive<byte>();
            Value = value == byte.MaxValue ? Il2CppMetadataIndex.Invalid : value;
        }
    }

    static int IReadable.Size(in StructVersion version, in ReaderConfig config)
        => GetSizeFromTag(in version);

    #region Operators + ToString

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Il2CppMetadataIndex<T>(int value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator int(Il2CppMetadataIndex<T> value) => value.Value;

    public static bool operator ==(Il2CppMetadataIndex<T> left, Il2CppMetadataIndex<T> right)
        => left.Value == right.Value;

    public static bool operator !=(Il2CppMetadataIndex<T> left, Il2CppMetadataIndex<T> right)
        => !(left == right);

    public readonly override bool Equals(object? obj)
        => obj is Il2CppMetadataIndex<T> other && Equals(other);

    public readonly bool Equals(Il2CppMetadataIndex<T> other)
        => this == other;

    public readonly override int GetHashCode()
        => HashCode.Combine(Value);

    public readonly override string ToString() => Value.ToString();

    #endregion
}