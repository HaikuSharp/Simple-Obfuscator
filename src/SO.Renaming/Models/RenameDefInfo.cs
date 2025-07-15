using dnlib.DotNet;

namespace SO.Renaming.Models;

public class RenameDefInfo(MDToken mdt, RenameData names) : RenameInfoBase(mdt)
{
    public RenameData Names => names;
}
