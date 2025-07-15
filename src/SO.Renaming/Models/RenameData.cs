using dnlib.DotNet;
using System;

namespace SO.Renaming.Models;

public readonly struct RenameData(UTF8String original, UTF8String renamed) : IEquatable<RenameData>
{
    public UTF8String Original => original;

    public UTF8String Renamed => renamed;

    public bool Equals(RenameData other) => original == other.Original;

    public override bool Equals(object obj) => obj is RenameData rdata && base.Equals(rdata);

    public override int GetHashCode() => original.GetHashCode();

    public override string ToString() => $"({original}: {renamed})";

    public static bool operator ==(RenameData left, RenameData right) => left.Equals(right);

    public static bool operator !=(RenameData left, RenameData right) => !(left == right);
}
