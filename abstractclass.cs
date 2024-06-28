using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//can't make obj of abstract class 
abstract class abstractanimal
{
    public abstract void makesound();
}

class abstractdog : abstractanimal
{
    public override void makesound()
    {
        Console.WriteLine("dog is making sound\n");
    }
}

class abstractcat : abstractanimal
{
    public override void makesound()
    {
        Console.WriteLine("cat is making sound\n");
    }
}

class abstractdonkey : abstractanimal
{
    public override void makesound()
    {
        Console.WriteLine("donkey is making sound\n");
    }
}

namespace OOP_in_Csharpe.com.organize
{
    class abstractclass
    {
    }
}
