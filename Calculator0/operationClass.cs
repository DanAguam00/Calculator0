using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator0
{
    class operationClass : ReferenceClass
    {
        public void Add()
        {
            Num1 = (float.Parse(Num0) + float.Parse(Num1)).ToString();
        }

        public void Subtract()
        {
            Num1 = (float.Parse(Num0) - float.Parse(Num1)).ToString();
        }

        public void Multiply()
        {
            Num1 = (float.Parse(Num0) * float.Parse(Num1)).ToString();
        }

        public void Divide()
        {
            Num1 = (float.Parse(Num0) / float.Parse(Num1)).ToString();
        }
    }
}
