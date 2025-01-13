using Demo.Encapsulation;
using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example constructor point         
            Point point1 = new Point();          
            Console.WriteLine(point1);


            Point point2 = new Point(12, 122);   
            Console.WriteLine(point2);



            Point point3 = new Point(3);           
            Console.WriteLine(point3);


            //point1 = new Point(12);               
            //Console.WriteLine(point1);

            //point1 = new Point(12, 133);
            //Console.WriteLine(point1);
            //#endregion


            //#region MyRegion syntax suger
            //Point p = new(10);
            //Console.WriteLine(p);
            #endregion



            #region Encapslation
            // EMPLOYEE employee = new EMPLOYEE();
            // Console.WriteLine(employee);
            // employee = new EMPLOYEE(1,"mora",12.3m);
            // Console.WriteLine(employee);
            //employee = new EMPLOYEE(1333);
            // Console.WriteLine(employee);
            #endregion


            #region Employee
            EMPLOYEE emp2 = new EMPLOYEE();
            emp2.SetId(11);
            emp2.SetName("mora samir");
            Console.WriteLine($"{emp2}"); 
            #endregion

        }
    }
}
