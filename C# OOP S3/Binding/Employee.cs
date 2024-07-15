using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S3.Binding
{
    internal class Employee // container
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? age { get; set; }
        
        public virtual void MyFunc01()
        {
            Console.WriteLine("iamEmployee");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"id : {id} , Name : {name} , age : {age}");
        }
    }
}
