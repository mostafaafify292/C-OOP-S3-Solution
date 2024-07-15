using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S3.overRiding
{
    internal class TypeA
    {
        public int A { get; set; }
        

        public TypeA(int _a)
        {
         A = _a;
        }
        public void MyFunc01()
        { Console.WriteLine("iAmBase"); }
        public virtual void MyFunc02() 
        { Console.WriteLine($"TypeA : A = {A}"); }
    }


    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        //Static binding method
        // compilation time [early binding]
        public new void MyFunc01()
        { Console.WriteLine("iAmChild"); }
        //Dynamic binding method
        // at run time [late binding]
        public override void MyFunc02()
        { Console.WriteLine($"TypeA : B = {B}"); }
    }



    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A , int _B , int _C):base(_A , _B)
        {
            C = _C;
        }
        public new void MyFunc01()
        { Console.WriteLine("iAm Grand Child"); }

        public override void MyFunc02()
        { Console.WriteLine($"TypeA : C = {C}"); }

    }


    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD (int _a , int _b ,int _c ,  int _d):base (_a , _b , _c)
        {
         D = _d;
        }
        public new void MyFunc01()
        { Console.WriteLine("iAm Grand Child"); }

        public new virtual void MyFunc02()
        { Console.WriteLine($"TypeA : D = {D}"); }
    }



    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _a, int _b, int _c, int _d , int _e) : base(_a, _b, _c , _d)
        {
            E = _e;         
        }
        public new void MyFunc01()
        { Console.WriteLine("iAm Grand Child"); }

        public override void MyFunc02()
        { Console.WriteLine($"TypeA : E = {E}"); }
    }
}
