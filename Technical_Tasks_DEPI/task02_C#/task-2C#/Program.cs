using System;

namespace task_2C_
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            #region prob 1
            //  initialize variable x with value 10
            int X = 10;

            //  initializ variable y with value 20
            int Y = 20;

            /* 
            sum of x and y 
               and store the result in the sum variable 
            */
            int sum=X+Y; 

            // Print 
            Console.WriteLine(sum);
            //Ctrl + K >> comment
            //ctrl + u >> uncomment
            #endregion
            #region prob 2

            int x = 10;
            int y = 3;
            int res = x + y;
            Console.WriteLine(res);

            //Runtime error is error while running like exception 
            //logical : when find the output not like the logic of code e
            //ex: when i write program sum to integers and find th output use the abstraction
            #endregion
            #region Prob 3
            string fullName = "Reem";
            int age = 25;
            decimal monthlySalary = 5000.00m;
            bool isStudent = false;
            #endregion
            #region prob 4

            //improves code readability, maintainability,
            //and consistency across projects.
            //It helps developers quickly understand
            //the purpose of variables, methods, and classes

            //Question:
            //Explain the difference between value types and reference types in terms of memory 
            //allocation.
            // value type :Stored in the stack (int , enum)
            //ref type : stored in heap(class , string )

            int a = 5;
            int b = 10;
            a = b;
            a++;
            #endregion
            #region prob 5
            int num1 = 10;
            int num2 = 5;
            int s = num1 + num2;
            int diff = num1 - num2;
            int product = num1 * num2;
            int division = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine($"{s } , {diff }");

            #endregion
        }
    }
}
