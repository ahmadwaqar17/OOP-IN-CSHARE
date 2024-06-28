using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class parent
{
    public parent()
    {
        Console.WriteLine("parent constructor ");
    }
    public void show()
    {
        Console.WriteLine("parent show ");
    }
}
class child : parent
{
    public  child()
    {
        Console.WriteLine("child constructor ");

    }

    new public void show()
    {
        Console.WriteLine("child show");
    }
}
namespace OOP_in_Csharpe.com.organize
{
    class Class1
    {
        child c1 = new child();

    }
}
