namespace SO.Tests.Assembly;

public class SomeClass : ISomeInterface
{
    [Some("Hello")]
    public int SomeProperty { get; set; } = 10;

    [Some("Hello")]
    public SomeStruct SomeMethod() => new();

    public class SomeNestedClass
    {
        public int SomeProperty { get; set; }
    }
}
