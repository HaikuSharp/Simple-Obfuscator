using dnlib.DotNet;

namespace SO.Renaming.Models;

public abstract class RenameInfoBase(MDToken mdt)
{
    public MDToken MetadataToken => mdt;
}
