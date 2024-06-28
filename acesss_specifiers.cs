using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BaseClass
{
    private int privateVar = 1;            // Private: Only accessible within this class
    protected int protectedVar = 2;        // Protected: Accessible within this class and derived classes
    internal int internalVar = 3;          // Internal: Accessible within this assembly
    protected internal int protectedInternalVar = 4; // Protected Internal: Accessible within this assembly and derived classes
    public int publicVar = 5;              // Public: Accessible from any class

    public void Display()
    {
        Console.WriteLine("BaseClass Access: ");
        Console.WriteLine("privateVar: " + privateVar);
        Console.WriteLine("protectedVar: " + protectedVar);
        Console.WriteLine("internalVar: " + internalVar);
        Console.WriteLine("protectedInternalVar: " + protectedInternalVar);
        Console.WriteLine("publicVar: " + publicVar);
    }
}

class DerivedClass : BaseClass
{
   new  public void Display()
    {
        Console.WriteLine("DerivedClass Access: ");
        // Console.WriteLine("privateVar: " + privateVar); // Error: Inaccessible due to protection level
        Console.WriteLine("protectedVar: " + protectedVar);
        Console.WriteLine("internalVar: " + internalVar);
        Console.WriteLine("protectedInternalVar: " + protectedInternalVar);
        Console.WriteLine("publicVar: " + publicVar);
    }
}

namespace OOP_in_Csharpe.com.organize
{
    class acesss_specifiers
    {
    }
}
