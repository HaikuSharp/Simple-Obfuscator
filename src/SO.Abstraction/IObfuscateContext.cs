using dnlib.DotNet;

namespace SO.Abstraction;

public interface IObfuscateContext
{
    ModuleDef CurrentModule { get; }

    bool IsObfuscate(ObfuscateDataId id);

    object GetData(ObfuscateDataId id);

    void MarkAsObfuscate(ObfuscateDataId id, object data);
}
