﻿using newProgramNameSpace;
using Consoles;
using inputOutputNamespace;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleExample console = new ConsoleExample();
            inputOutput inputOutputObject = new inputOutput();
            // console.allConsoles();
            // inputOutputObject.runInputOutput();
            // -------------
           
            // -------------type int while taking input
            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is: " + age);

            // ---------------------------
            // int numberHere = 5;
            // Console.WriteLine(numberHere++);
            // Console.WriteLine(numberHere);
            // Console.WriteLine(++numberHere);
            // Console.WriteLine(10%2);
            // Console.WriteLine(10/5);


            // --------------------------- Assignment Operators
            // int x = 10;
            // x += 5;
            // Console.WriteLine(x);

            // int one = 1234;
            // int two = 1234;
            // Console.WriteLine(one == two);
            // Console.WriteLine(one != two);
            // Console.WriteLine("--");
            // Console.WriteLine(true && true);
            // Console.WriteLine(true && false);
            // Console.WriteLine(true || false);
            // Console.WriteLine(false || false);
            // Console.WriteLine(!true);
            // Console.WriteLine(!false);


            // --------------------------- String method
            // string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // Console.WriteLine("The length of the txt string is: " + txt.Length);

            // string txt2 = "Hello World";
            // Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            // Console.WriteLine(txt2.ToLower());   // Outputs "hello world"

            // string firstName = "John";
            // string lastName = "Doe";
            // string name = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);

            // bool flag = false;
            // string conditionalString = flag ? "flag true" : "flag false"; 
            // Console.WriteLine(conditionalString);

            // --------------------------- Loop
            // for(int i=0;i<5;i++){
            //     Console.WriteLine(i);
            // }

            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            // foreach(string car in cars){
            //     Console.WriteLine(car);
            // }

            
            // -------------Methods 
            MyMethod();
            MyMethod("this is string");
            MyMethod(1234);
            newProgramClass n = new newProgramClass();
            n.newProgramMethod("test name");
        }
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void MyMethod(string str)
        {
            Console.WriteLine("I just got executed! str --> " + str);
        }
        static void MyMethod(int i)
        {
            Console.WriteLine("I just got executed! int --> " + i);
        }
    }
}