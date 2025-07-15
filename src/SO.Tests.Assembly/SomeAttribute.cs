using System;

namespace SO.Tests.Assembly;

[Some("Hello")]
[Some("Hello")]
[Some("Hello")]
[Some("Hello")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public class SomeAttribute(string str) : Attribute
{
    public string SomeString => str;
}