using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S3.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public override void MyFunc01()
        {
            Console.WriteLine("iam PartTime Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"id : {id} , Name : {name} , age : {age} , HourRate : {HourRate}");

        }
    }
}
