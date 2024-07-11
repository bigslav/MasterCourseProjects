namespace AMLibrary;

public class PublicClass
{
    public int PublicField { get; set; } // accessed anywhere in this and other assemblies
    int privateValue; // access only inside this class
    protected int ProtectedField { get; set; } // accessed in this or derived class in this and other assemblies
    protected internal int ProtectedInternalField { get; set; } // accessed in this assembly and for parent and derived classes in other assemblies
    private protected int PrivateProtectedField { get; set; } // accessed only in this assembly and for parent and derived classes
}

public class PublicClassChild : PublicClass
{
    PublicClass _publicClass;

    public PublicClassChild()
    {
        PublicField = 0; // has access
        ProtectedField = 0; // has access
        ProtectedInternalField = 0; // has access
        PrivateProtectedField = 0;

        _publicClass = new PublicClass();
        _publicClass.ProtectedInternalField = 0; // has access due to Internal part, also can be accessed in a derived class in another assembly
    }
}
