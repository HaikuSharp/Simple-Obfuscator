using dnlib.DotNet;
using SO.Renaming.Abstraction;

namespace SO.Renaming.Confusing;

public class InvalidCharacterStringConfuser : IStringConfuser
{
    private const int FIRST_INVALID_CHAR = 0xE000; // 57344

    public UTF8String Confuse(UTF8String original) => ((char)(FIRST_INVALID_CHAR + original.GetHashCode())).ToString();
}
