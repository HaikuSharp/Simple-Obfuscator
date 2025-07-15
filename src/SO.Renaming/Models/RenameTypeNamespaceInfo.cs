using dnlib.DotNet;

namespace SO.Renaming.Models;

public class RenameTypeNamespaceInfo(MDToken mdt, RenameData names) : RenameInfoBase(mdt)
{
    public RenameData NamespaceNames => names;
}