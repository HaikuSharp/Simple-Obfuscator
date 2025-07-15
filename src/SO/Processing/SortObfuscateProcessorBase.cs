using SO.Abstraction;

namespace SO.Processing;

public abstract class SortObfuscateProcessorBase<TObfuscateTarget>(IObfuscateProcessor<TObfuscateTarget> processor) : IObfuscateProcessor<TObfuscateTarget> where TObfuscateTarget : class
{
    public void Process(TObfuscateTarget target, IObfuscateContext context)
    {
        if(!PredicateTarget(target)) return;
        processor.Process(target, context);
    }

    protected abstract bool PredicateTarget(TObfuscateTarget target);
}
