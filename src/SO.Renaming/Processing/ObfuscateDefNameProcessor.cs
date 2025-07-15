using dnlib.DotNet;
using SO.Abstraction;
using SO.Extensions;
using SO.Renaming.Abstraction;
using SO.Renaming.Models;

namespace SO.Renaming.Processing;

public class ObfuscateDefNameProcessor(IStringConfuser confuser) : IObfuscateProcessor<IDnlibDef>
{
    public void Process(IDnlibDef target, IObfuscateContext context)
    {
        if(context.IsObfuscate<RenameDefInfo>(target)) return;
        string originalName = target.Name;
        context.MarkAsObfuscate<RenameDefInfo>(target, new(target.MDToken, new(originalName, target.Name = confuser.Confuse(originalName))));
    }
}
