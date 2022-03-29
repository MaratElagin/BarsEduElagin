using System.Diagnostics;

namespace Generic;

public class MyClass
{
}

public struct MyStruct
{
}

class Program
{
    static void Main(string[] args)
    {
        // string filePath = "D:/Projects/c# proj/Generic/myClassLoger.txt";
        // var loger = new LocalFileLogger<MyClass>(filePath);
        // loger.LogInfo("Hello from MyClass");
        // loger.LogWarning("Hello from MyClass");
        // loger.LogError("Hello from MyClass", new ArgumentException("Bad parameter for class"));

        string filePath = "D:/Projects/c# proj/Generic/myStructLoger.txt";
        var loger = new LocalFileLogger<MyStruct>(filePath);
        loger.LogInfo("Hello from MyClass");
        loger.LogWarning("Hello from MyClass");
        loger.LogError("Hello from MyClass", new ArgumentException("Bad parameter for struct"));
    }
}