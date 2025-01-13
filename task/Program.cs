using System.Net.Cache;

namespace task
{
    internal class Program
    {
        private static object Name;

        static void Main(string[] args)
        {
            #region Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
      
            Person[] p1 = new [] {
                                 new Person() { Age=1,Name="mora"},
                                 new Person() { Age=2,Name="samir"},
                                 new Person() { Age=3,Name="alaa" }

                                  };

            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);

            }
            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". 
            //Write a C# program that takes two points as input from the user and calculates the distance between them
            int a, b, c, d;
            Point point = new Point();
            bool flag;
            Point point1 = new Point();
            Point point2 = new Point();
            Point distance = new Point();
            do
            {
                Console.WriteLine("Enter point1.x");
                flag = int.TryParse(Console.ReadLine() ?? "0", out a);
                Console.WriteLine("Enter point1.y");
                flag = int.TryParse(Console.ReadLine() ?? "0", out b);

                Console.WriteLine("Enter point2.x");
                flag = int.TryParse(Console.ReadLine() ?? "0", out c);
                Console.WriteLine("Enter point2.y");
                flag = int.TryParse(Console.ReadLine() ?? "0", out d);

            } while (!flag);

            point1.X = a;
            point1.Y = b;

            point2.X = c;
            point2.Y = d;

            distance.X = (point1.X - point2.X);
            distance.Y = (point1.Y - point2.Y);
            double Result = Math.Sqrt(Math.Pow(distance.X, 2) + Math.Pow(distance.Y, 2));
            Console.WriteLine(Result);
            #endregion

            #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            int n = 0;
            bool flag1;
            string name;
            Person[] person = new Person[3]
            {
                                 new Person() { Age = 1, Name = "mora" },
                                 new Person() { Age = 2, Name = "samir" },
                                 new Person() { Age = 3, Name = "alaa" },
             };


            for (int j = 0; j < person.Length;)

            {
                do
                {
                    Console.WriteLine($"ENter Data of person {j + 1}  input  Name");
                    name = Console.ReadLine() ?? "invalid ";
                    Console.WriteLine($"ENter Data of person {j + 1} input  age");
                    flag1 = int.TryParse(Console.ReadLine(), out n);

                } while (!flag1 || name == "invalid");
                person[j].Age = n;
                person[j].Name = name;

                j++;
            }

            #endregion

            #region Rectangle
            Rectangle Rectangle1 = new Rectangle(12, 3);
            Console.WriteLine(Rectangle1);
            #endregion




        }
        }
}
