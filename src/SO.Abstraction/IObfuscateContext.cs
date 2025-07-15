namespace SO.Abstraction;

public interface IObfuscateContext
{
    bool IsObfuscate(ObfuscateDataId id);

    object GetData(ObfuscateDataId id);

    void MarkAsObfuscate(ObfuscateDataId id, object data);
}
