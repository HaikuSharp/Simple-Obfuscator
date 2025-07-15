using dnlib.DotNet;
using SO.Abstraction;
using SO.Extensions;

namespace SO.Renaming;

public class RandomInvalidCharacterNameSpaceTypeDefObfuscatorProcessor : IObfuscateProcessor<TypeDef>
{
    private int m_LastIndex;

    public void Process(TypeDef target, IObfuscateContext context)
    {
        if(context.IsObfuscate<RenameTypeNamespaceInfo>(target)) return;

        string originalName = target.Namespace;
        string newName = InternalRenameTool.GetInvalidCharByIndex(m_LastIndex++).ToString();

        target.Namespace = newName;

        context.MarkAsObfuscate<RenameTypeNamespaceInfo>(target, new(target.MDToken, new(originalName, newName)));
    }
}
