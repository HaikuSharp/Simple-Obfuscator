using dnlib.DotNet;
using SO.Abstraction;

namespace SO.Processing.Defs;

public class ObfuscateTypeDefNestedTypesDefsProcessor(IObfuscateProcessor<TypeDef> nestedTypeDefProcessor) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        foreach(var nestedTypeDef in target.NestedTypes) nestedTypeDefProcessor.Process(nestedTypeDef, context);
    }
}
