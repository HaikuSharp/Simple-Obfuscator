using dnlib.DotNet;

namespace SO.Renaming;

public abstract class RenameInfoBase(MDToken mdt)
{
    public MDToken MetadataToken => mdt;
}
