using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class animal { 

 public virtual void makesound()
    {
        Console.WriteLine("animal is making soound \n");

    }
}

class dog :animal
{

    public override void makesound()
    {
        Console.WriteLine("dog  is making soound \n");

    }
}
class cat: animal
{

    public override void makesound()
    {
        Console.WriteLine("cat  is making soound \n");

    }
}
class donkey : animal
{

    public override void makesound()
    {
        Console.WriteLine("donkey is making soound \n");

    }
}

namespace OOP_in_Csharpe.com.organize
{
    class polymorphisim
    {
    }
}
