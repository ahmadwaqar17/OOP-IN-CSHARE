using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class parent1
{
    public parent1(string name )
    {
        Console.WriteLine("parent = " +name);
    }
}
class child1 : parent1
{
    public child1(string n) : base(n)
    {
        Console.WriteLine("child =" + n);
    }
}
namespace OOP_in_Csharpe.com.organize
{
    class para_constructor
    {
    }
}
