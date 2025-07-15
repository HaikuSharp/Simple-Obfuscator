using System;

namespace SO.Tests.Assembly;

[Some("")]
[Some("")]
[Some("")]
[Some("")]
public static class SomeStaticClass
{
    [Some(nameof(SomeStruct))]
    [Some("Hello")]
    [Some("const")]
    [Some("SomeStaticMethod")]
    [Some("SomeStaticClass")]
    public static void SomeStaticMethod()
    {
        SomeGenericClass<SomeClass> someGenericClass = new(new());
        Console.WriteLine($"{nameof(SomeGenericClass<>)}: {someGenericClass.Value.SomeProperty}");
    }
}
