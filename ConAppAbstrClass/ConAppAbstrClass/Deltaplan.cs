using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppAbstrClass
{ 
    class Deltaplan : FlyingMachine
    {
        int wWing;//розмах крила
        string typeCloth; //тип тканини (полімерна нитка або шовк)

        public int WWing //властивість - розмах крила
        {
            get { return wWing; }
            set { wWing = value; }  

        }

        public string tCloth //властивість - тип тканини
        {

            get { return typeCloth; }
            set { typeCloth = value; }
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

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
