namespace SO.Abstraction;

public interface IObfuscateProcessor<in TObfuscateTarget> where TObfuscateTarget : class
{
    void Process(TObfuscateTarget target, IObfuscateContext context);
}
