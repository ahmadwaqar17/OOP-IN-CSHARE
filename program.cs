using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_Csharpe
{
    class car
    {
        public string name;
        public int model;
        public string color;

      public   void setvalues()
        {
            Console.WriteLine("Name = {0} model = {1} color ={2}" ,name, model, color);
        }
    }
    class mainclass
    {
        private static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            car c1 = new OOP_in_Csharpe.car();
            c1.color = "blue";
            c1.model = 2002;
            c1.name = "civic";

            c1.setvalues();

            Console.WriteLine("constructor life cycle\n ");
            child c = new child();

            Console.WriteLine("para constructor\n");

            child1 chill = new child1("tata");
            Console.WriteLine("same method in parent and child \n");
            c.show();


            Console.WriteLine("multilvl inheritence \n ");
            

            Console.WriteLine("acess specifiers \n");
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();

            baseObj.Display();
            derivedObj.Display();

            Console.WriteLine("Program Access: ");
            // Console.WriteLine("privateVar: " + baseObj.privateVar); // Error: Inaccessible due to protection level
            // Console.WriteLine("protectedVar: " + baseObj.protectedVar); // Error: Inaccessible due to protection level
            Console.WriteLine("internalVar: " + baseObj.internalVar);
            Console.WriteLine("protectedInternalVar: " + baseObj.protectedInternalVar);
            Console.WriteLine("publicVar: " + baseObj.publicVar);


            Console.WriteLine("encapsulation \n ");

            BankAccount account = new BankAccount("1234567890");
            account.Deposit(1000);
            Console.WriteLine($"Balance: {account.GetBalance()}");

            // Direct access to account number is restricted
            // Console.WriteLine($"Account Number: {account.accountNumber}");

            Console.WriteLine($"Account Number: {account.GetAccountNumber()}");


            Console.WriteLine("\npolymorphism \n");
            animal an = new cat();
            an.makesound();
            animal an1 = new dog();
            an1.makesound();
            animal an2 = new donkey();
            an2.makesound();


            Console.WriteLine("\n Abstract class \n");

            abstractanimal dog = new abstractdog();
            abstractanimal cat = new abstractcat();
            abstractanimal donkey = new abstractdonkey();

            dog.makesound(); // Output: dog is making sound
            cat.makesound(); // Output: cat is making sound
            donkey.makesound(); // Output: donkey is making sound
            
            Console.WriteLine("\n Delegates \n");
            

            add obj = new add(sum);
            int result = obj(2, 3);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
