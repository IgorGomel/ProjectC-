using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppAbstrClass
{
    abstract class FlyingMachine
    {
       public string name;
       public int maxMove;
       public int maxHeight;
       public int mass;

       public static virtual string Name//властивість - макс швидкість
       {
           get;
           set;
       }
       public virtual int Move//властивість - макс швидкість
       {
           get;
           set;
       }

        public virtual int Height//властивість - макс висота
        {
            get;
            set;
        }
        public virtual int Mass //властивість - маса, вага
        {
            get;
            set;
        }
    }
}
