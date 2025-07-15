using dnlib.DotNet;
using SO.Extensions;
using SO.Abstraction;

namespace SO.Renaming;

public class RandomInvalidCharacterNameObfuscateProcessor : IObfuscateProcessor<IDnlibDef>
{
    private int m_LastIndex;

    public void Process(IDnlibDef target, IObfuscateContext context)
    {
        if(context.IsObfuscate<RenameDefInfo>(target)) return;

        var originalName = target.Name;
        var newName = InternalRenameTool.GetInvalidCharByIndex(m_LastIndex++).ToString();

        target.Name = newName;
        context.MarkAsObfuscate<RenameDefInfo>(target, new(target.MDToken, new(originalName, newName)));
    }
}
