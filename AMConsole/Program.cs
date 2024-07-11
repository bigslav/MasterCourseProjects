// See https://aka.ms/new-console-template for more information
using AMLibrary;

Console.WriteLine("Hello, World!");

PublicClass publicClass = new PublicClass();
publicClass.PublicField = 0; // has only access to public prop

public class PublicClassChildInOtherAssembly : PublicClass
{
    public PublicClassChildInOtherAssembly()
    {
        PublicField = 0; // has access as it's public
        ProtectedField = 0; // has access as it is accessed from a derived class
        ProtectedInternalField = 0; // Internal, but has access as it is accessed from a derived class in another assembly (protected internal)
    }
}