using C__OOP_S3.Binding;
using C__OOP_S3.overRiding;

namespace C__OOP_S3
{
    internal class Program
    {
        #region SumFunction
        public static int sum(int x, int y)
        {

            return x + y;
        }
        public static int sum(int x, int y, int z)
        {

            return x + y + z;
        }
        public static int sum(int x, int y, int z, int n)
        {

            return x + y + z + n;
        }
        #endregion
        public static void ProcessEmp(Employee employee)
        {
            if (employee != null)
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }


        }
        static void Main(string[] args)
        {
            #region ProgramForSumOverLoading
            //int result;
            //result = sum(1, 2, 3);
            //Console.WriteLine(result);
            //result = sum(1, 2, 3, 4);
            //Console.WriteLine(result);
            #endregion
            #region OverRiding
            //TypeA typeA = new TypeA(1);
            //typeA.A = 2;
            //typeA.MyFunc01();
            //typeA.MyFunc02();

            //TypeB typeB = new TypeB(1 , 2 );
            //typeB.A = 3;
            //typeB.B = 4;
            //typeB.MyFunc01();
            //typeB.MyFunc02(); 
            #endregion
            #region Binding

            ////Binding
            ////referance from paresnt = object from child
            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 3;
            //RefBase.MyFunc01();
            ////static binding Method
            //RefBase.MyFunc02();
            ////Dynamic binding Method 
            #endregion
            #region NotBinding
            //TypeA typeA = new TypeB(1 , 2 ) ; //binding
            //TypeB typeB = (TypeB)typeA; // casting 
            #endregion
            #region Bussniess Need of Binding
            //Employee fullTime = new FullTimeEmployee()
            //{
            //    id = 1,
            //    name = "Test",
            //    age = 1,
            //    salary = 1000,
            //};

            //ProcessEmp(fullTime);

            //Employee partTime = new PartTimeEmployee()
            //{
            //    id = 10,
            //    name = "mona",
            //    age = 20,
            //    HourRate = 25
            //};
            //ProcessEmp(partTime);  
            #endregion
            #region More practise 
            //TypeA typeA = new TypeC(1 , 2 , 3);
            //typeA.A = 1;
            //typeA.MyFunc01();//[base]
            //typeA.MyFunc02();//[dynamic binding c = 3]
            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 1;
            //typeB.B= 2;
            //typeB.MyFunc01();//[base or ref]
            //typeB.MyFunc02();//[dynamic binding C = 3]

            //TypeA typeA = new TypeE(1,2,3,4,5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFunc02();
            //typeD.MyFunc02();



            #endregion






        } 
       
    }
}
