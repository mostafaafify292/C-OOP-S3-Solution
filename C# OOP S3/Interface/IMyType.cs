using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S3.Interface
{
    internal interface IMyType
    {
        public int Age { get; set; } // signature for property

        //signature for method

        public void MyFunction();

        //defult implemented method
        public void Print()
            { Console.WriteLine("Defult implemented for method"); }

    }
}
