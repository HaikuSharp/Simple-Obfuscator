using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class Obfuscator(IObfuscateProcessor<ModuleDef> processor) : IObfuscator
{
    public IObfuscateContext Obfuscate(ModuleDef originalModule)
    {
        ObfuscateContext context = new(originalModule);
        processor.Process(originalModule, context);
        return context;
    }
}
