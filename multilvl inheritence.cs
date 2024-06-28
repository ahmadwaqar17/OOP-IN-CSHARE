using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class gp {
    public gp()
    {
        Console.WriteLine("grandparent construct0r mli");
    }
}
class p : gp
{
    public p()
    {
        Console.WriteLine("parent construct0r mli");
    }
}

class gc :p
{
    public gc()
    {
        Console.WriteLine("child construct0r mli");
    }
}

namespace OOP_in_Csharpe.com.organize
{
    class multilvl_inheritence
    {
    }
}
