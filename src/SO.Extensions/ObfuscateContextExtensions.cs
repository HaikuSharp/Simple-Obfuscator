using dnlib.DotNet;
using SO.Abstraction;

namespace SO.Extensions;

public static class ObfuscateContextExtensions
{
    public static bool IsObfuscate<TData>(this IObfuscateContext context, IMDTokenProvider provider) => context.IsObfuscate(new(provider.MDToken, typeof(TData)));

    public static TData GetData<TData>(this IObfuscateContext context, IMDTokenProvider provider) where TData : class => context.GetData(new(provider.MDToken, typeof(TData))) as TData;

    public static void MarkAsObfuscate<TData>(this IObfuscateContext context, IMDTokenProvider provider, TData data) where TData : class => context.MarkAsObfuscate(new(provider.MDToken, typeof(TData)), data);
}
