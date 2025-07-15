using dnlib.DotNet;

namespace SO.Renaming.Abstraction;

public interface IStringConfuser
{
    UTF8String Confuse(UTF8String original);
}
