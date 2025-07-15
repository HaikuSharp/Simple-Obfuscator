using dnlib.DotNet;
using SO.Abstraction;
using SO.Extensions;
using SO.Renaming.Abstraction;
using SO.Renaming.Models;

namespace SO.Renaming.Processing;

public class ObfuscatorTypeDefNamespaceProcessor(IStringConfuser confuser) : IObfuscateProcessor<TypeDef>
{
    public void Process(TypeDef target, IObfuscateContext context)
    {
        if(context.IsObfuscate<RenameTypeNamespaceInfo>(target)) return;
        string originalName = target.Namespace;
        context.MarkAsObfuscate<RenameTypeNamespaceInfo>(target, new(target.MDToken, new(originalName, target.Namespace = confuser.Confuse(originalName))));
    }
}
