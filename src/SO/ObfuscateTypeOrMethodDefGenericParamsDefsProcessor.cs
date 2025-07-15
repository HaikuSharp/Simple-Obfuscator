using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class ObfuscateTypeOrMethodDefGenericParamsDefsProcessor(IObfuscateProcessor<GenericParam> genericParamDefProcessor) : IObfuscateProcessor<ITypeOrMethodDef>
{
    public void Process(ITypeOrMethodDef target, IObfuscateContext context)
    {
        if(!target.HasGenericParameters) return;
        foreach(var genericParamDef in target.GenericParameters) genericParamDefProcessor.Process(genericParamDef, context);
    }
}
