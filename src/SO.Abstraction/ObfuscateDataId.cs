using dnlib.DotNet;
using System;

namespace SO.Abstraction;

public readonly struct ObfuscateDataId(MDToken mdt, Type dataType) : IEquatable<ObfuscateDataId>
{
    private readonly MDToken m_Token = mdt;
    private readonly Type m_DataType = dataType;

    public bool Equals(ObfuscateDataId other) => m_Token == other.m_Token;

    public override bool Equals(object obj) => obj is ObfuscateDataId rinfo && base.Equals(rinfo);

    public override int GetHashCode() => m_Token.GetHashCode();

    public override string ToString() => $"({m_DataType}: {m_Token})";

    public static bool operator ==(ObfuscateDataId left, ObfuscateDataId right) => left.Equals(right);

    public static bool operator !=(ObfuscateDataId left, ObfuscateDataId right) => !(left == right);
}
