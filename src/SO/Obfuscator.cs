using dnlib.DotNet;
using SO.Abstraction;
using System.Collections.Generic;

namespace SO;

public class Obfuscator(IObfuscateProcessor<ModuleDef> processor) : IObfuscator
{
    public IObfuscateContext Obfuscate(ModuleDef originalModule)
    {
        ObfuscateContext context = new(originalModule);
        processor.Process(originalModule, context);
        return context;
    }

    private class ObfuscateContext(ModuleDef currentModule) : IObfuscateContext
    {
        private readonly Dictionary<ObfuscateDataId, object> m_ObfuscateDatas = [];

        public ModuleDef CurrentModule => currentModule;

        public bool IsObfuscate(ObfuscateDataId id) => m_ObfuscateDatas.ContainsKey(id);

        public object GetData(ObfuscateDataId id) => m_ObfuscateDatas[id];

        public void MarkAsObfuscate(ObfuscateDataId id, object data)
        {
            if(IsObfuscate(id)) return;
            m_ObfuscateDatas[id] = data;
        }
    }
}
