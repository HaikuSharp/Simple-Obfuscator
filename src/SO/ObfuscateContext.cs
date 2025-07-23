using dnlib.DotNet;
using SO.Abstraction;
using System.Collections.Generic;

namespace SO;

public class ObfuscateContext(ModuleDef currentModule) : IObfuscateContext
{
    private readonly Dictionary<ObfuscateDataId, object> m_ObfuscateData = [];

    public ModuleDef CurrentModule => currentModule;

    public bool IsObfuscate(ObfuscateDataId id) => m_ObfuscateData.ContainsKey(id);

    public object GetData(ObfuscateDataId id) => m_ObfuscateData[id];

    public void MarkAsObfuscate(ObfuscateDataId id, object data)
    {
        if(IsObfuscate(id)) return;
        m_ObfuscateData[id] = data;
    }
}
