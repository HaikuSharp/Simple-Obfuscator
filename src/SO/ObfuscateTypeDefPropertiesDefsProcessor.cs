using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class ObfuscateTypeDefPropertiesDefsProcessor(IObfuscateProcessor<PropertyDef> propertyDefProcessor) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        foreach(var propertyDef in target.Properties) propertyDefProcessor.Process(propertyDef, context);
    }
}
