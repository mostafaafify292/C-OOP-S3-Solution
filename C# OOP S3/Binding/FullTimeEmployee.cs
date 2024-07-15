using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S3.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal  salary { get; set; }

        public override void MyFunc01()
        {
            Console.WriteLine("iam Fulltime Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"id : {id} , Name : {name} , age : {age} , salary : {salary}");

        }
    }
}
