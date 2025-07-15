using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class ObfuscateModuleDefTypesDefsProcessor(IObfuscateProcessor<TypeDef> typeDefProcessor) : IObfuscateProcessor<ModuleDef>
{
    public void Process(ModuleDef target, IObfuscateContext context)
    {
        foreach(var typeDef in target.GetTypes()) typeDefProcessor.Process(typeDef, context);
    }
}
