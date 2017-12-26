using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppAbstrClass
{
    
    public static class Helicopter : FlyingMachine
    {
        static int motorPower;//потужність двигуна
        static int fuelStock; //запас палива
        int DHelicopRotor; //діаметр несучого гвинта

        public static int mPower //властивість - потужність двигуна
        {
            get { return motorPower;}
            set{motorPower = value;}
        }

        public static int fStock //властивість - запас палива
        {
            get { return fuelStock; }
            set { fuelStock = value; }
        }

        public int dRotor //властивість - діаметр несучого гвинта
        {
            get { return DHelicopRotor; }
            set { DHelicopRotor = value; }
        }

        //реалізовуємо властивості, оголошені в абстрактному класі FlyingMachine
        public override int Move
        {
            get { return maxMove; }
            set { maxMove = value; }
        }

        public override int Height
        {
            get { return maxHeight; }
            set { maxHeight = value; }
        }

        public override int Mass
        {
            get { return mass; }
            set { mass = value; }
        }
    }
}
