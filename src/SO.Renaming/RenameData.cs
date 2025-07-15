using System;

namespace SO.Renaming;

public readonly struct RenameData(string original, string renamed) : IEquatable<RenameData>
{
    public string Original => original;

    public string Renamed => renamed;

    public bool Equals(RenameData other) => original == other.Original;

    public override bool Equals(object obj) => obj is RenameData rdata && base.Equals(rdata);

    public override int GetHashCode() => original.GetHashCode();

    public override string ToString() => $"({original}: {renamed})";

    public static bool operator ==(RenameData left, RenameData right) => left.Equals(right);

    public static bool operator !=(RenameData left, RenameData right) => !(left == right);
}
