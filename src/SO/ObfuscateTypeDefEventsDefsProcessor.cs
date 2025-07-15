using dnlib.DotNet;
using SO.Abstraction;

namespace SO;

public class ObfuscateTypeDefEventsDefsProcessor(IObfuscateProcessor<EventDef> eventDefProcessor) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        foreach(var eventDef in target.Events) eventDefProcessor.Process(eventDef, context);
    }
}
