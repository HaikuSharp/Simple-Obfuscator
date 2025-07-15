namespace SO.Renaming;

internal static class InternalRenameTool
{
    private const int CHARS_START = 0xE000; // 57344

    internal static char GetInvalidCharByIndex(int index) => (char)(CHARS_START + index);
}
