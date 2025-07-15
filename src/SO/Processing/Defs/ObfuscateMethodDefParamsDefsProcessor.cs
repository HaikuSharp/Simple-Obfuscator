using dnlib.DotNet;
using SO.Abstraction;

namespace SO.Processing.Defs;

public class ObfuscateMethodDefParamsDefsProcessor(IObfuscateProcessor<ParamDef> paramDefProcessor) : IObfuscateProcessor<MethodDef>
{
    public void Process(MethodDef target, IObfuscateContext context)
    {
        foreach(var paramDef in target.ParamDefs) paramDefProcessor.Process(paramDef, context);
    }
}
