using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppAbstrClass
{
    class MyGeneric<T>  
    {
        private static  int initSize = 16;
        private Object[] arr = new Object[initSize];
        private int pointer = 0;

        public void add(T item)
        {
            if (pointer == arr.Length - 1)
                Array.Resize(ref arr, arr.Length * 2); // збільшую масив в 2 рази, якщо він досяг межі
            arr[pointer++] = item;
        }

        public void show(int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The name of Helicopter: " );//введіть назву
            }

        }

        
        

    }
}
