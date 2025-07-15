using SO.Abstraction;
using System.Collections.Generic;

namespace SO;

public class BulkObfuscateProcessor<TObfuscateTarget>(IEnumerable<IObfuscateProcessor<TObfuscateTarget>> processors) : IObfuscateProcessor<TObfuscateTarget> where TObfuscateTarget : class
{
    public void Process(TObfuscateTarget target, IObfuscateContext context)
    {
        foreach(var processor in processors) processor.Process(target, context);
    }
}
