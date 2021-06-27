using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator0
{
    class ReferenceClass
    {
        private String operation = "";
        private Boolean operationPressed = false;
        private String num0 = "";
        private String num1 = "";

        public string Operation { get => operation; set => operation = value; }
        public bool OperationPressed { get => operationPressed; set => operationPressed = value; }
        public string Num0 { get => num0; set => num0 = value; }
        public string Num1 { get => num1; set => num1 = value; }

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
