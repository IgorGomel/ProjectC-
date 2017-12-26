using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppAbstrClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            //cki.Key = ConsoleKey.Escape();
            
            //Console.WriteLine("Enter the number of elements: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            MyGeneric<FlyingMachine> myArr = new MyGeneric<FlyingMachine>();

            int ch;
            Console.WriteLine("Change the type of FlyingMachine.");


            //for (int i = 0; i < n; i++)
            while (cki.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("For chaging Helicopter input 0, for chaging Deltaplan input 1: ");

                ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 0)
                {
                    /*Helicopter someHelicopter = new Helicopter();
                    Console.WriteLine("Enter the name of Helicopter: ");//введіть назву
                    someHelicopter.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the motors power of Helicopter: ");//введіть потужність двигуна
                    someHelicopter.mPower = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fuel stock of Helicopter: ");//введіть запас палива
                    someHelicopter.fStock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rotors diametr of Helicopter: ");//введіть діаметр несучого гвинта
                    someHelicopter.dRotor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter max move of Helicopter: ");//введіть максимальну швидкість
                    someHelicopter.Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter max flights heigh  of Helicopter: ");//введіть максимальну висоту польоту
                    someHelicopter.Height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mass  of Helicopter: ");//введіть масу
                    someHelicopter.Mass = Convert.ToInt32(Console.ReadLine());*/
                    Helicopter.Name = Convert.ToString(Console.ReadLine());
                    Helicopter.mPower = Convert.ToInt32(Console.ReadLine());
                    Helicopter.fStock = Convert.ToInt32(Console.ReadLine());
                    myArr.add(Helicopter);
                    //myArr.add(someHelicopter);
                }

                if (ch == 1)
                {
                    Deltaplan someDeltaplan = new Deltaplan();
                    Console.WriteLine("Enter the name of Deltaplan: ");//введіть назву
                    someDeltaplan.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the wings of the Deltaplan: ");//введіть розмах крила
                    someDeltaplan.WWing = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the type of cloth of the Deltaplan: ");//введіть тип тканини крила
                    someDeltaplan.tCloth = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter max move of the Deltaplan: ");//введіть максимальну швидкість
                    someDeltaplan.Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter max flights heigh  of the Deltaplan: ");//введіть максимальну висоту польоту
                    someDeltaplan.Height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mass  of Deltaplan: ");//введіть масу
                    someDeltaplan.Mass = Convert.ToInt32(Console.ReadLine());

                    myArr.add(someDeltaplan);


                }
            }

            /*
            FlyingMachine [] arr = new FlyingMachine[n];

            int ch;
            Console.WriteLine("Change the type of FlyingMachine.");
            

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("For chaging Helicopter input 0, for chaging Deltaplan input 1: ");

                ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 0)
                {
                    arr[n] = new Helicopter();
                }

                if (ch == 1)
                {
                    arr[n] = new Deltaplan();
                }
            }
            */
        }
    }
}
