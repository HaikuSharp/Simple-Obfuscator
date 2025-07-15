using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class ObfuscateTypeDefMethodsDefsProcessor(IObfuscateProcessor<MethodDef> methodDefProcessor) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        foreach(var methodDef in target.Methods) methodDefProcessor.Process(methodDef, context);
    }
}
