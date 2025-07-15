using SO.Abstraction;

namespace SO.Processing;

public class ScriptableSortObfuscateProcessor<TObfuscateTarget>(ScriptableSortObfuscateProcessor<TObfuscateTarget>.ObfuscateTargetHandler predicateTarget, IObfuscateProcessor<TObfuscateTarget> processor) : SortObfuscateProcessorBase<TObfuscateTarget>(processor) where TObfuscateTarget : class
{
    public delegate bool ObfuscateTargetHandler(TObfuscateTarget target);

    protected override bool PredicateTarget(TObfuscateTarget target) => predicateTarget(target);
}
