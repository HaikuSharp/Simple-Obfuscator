using dnlib.DotNet;
using SO.Abstraction;

namespace SO.Processing.Defs;

public class ObfuscateTypeDefFieldsDefsProcessor(IObfuscateProcessor<FieldDef> fieldDefProcessor) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        foreach(var field in target.Fields) fieldDefProcessor.Process(field, context);
    }
}
