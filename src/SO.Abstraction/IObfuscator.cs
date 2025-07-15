using dnlib.DotNet;

namespace SO.Abstraction;

public interface IObfuscator
{
    IObfuscateContext Obfuscate(ModuleDef originalModule);
}
