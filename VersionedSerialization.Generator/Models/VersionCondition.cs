﻿namespace VersionedSerialization.Generator.Models;

public sealed record VersionCondition(StructVersion? LessThan, StructVersion? GreaterThan, StructVersion? EqualTo, string? IncludingTag, string? ExcludingTag);