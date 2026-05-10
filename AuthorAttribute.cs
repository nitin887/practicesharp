/*
🧩 1. Attributes
💻 Coding Problem

Create a custom attribute AuthorAttribute:

*/
using System.Reflection;
using System.Reflection.Metadata;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorAttribute : Attribute
{
    public string Message;
    public AuthorAttribute(string message)
    {
        Message = message;

    }
}
