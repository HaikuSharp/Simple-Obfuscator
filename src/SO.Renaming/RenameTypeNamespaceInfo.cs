using dnlib.DotNet;

namespace SO.Renaming;

public class RenameTypeNamespaceInfo(MDToken mdt, RenameData names) : RenameInfoBase(mdt)
{
    public RenameData NamespaceNames => names;
}