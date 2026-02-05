// See https://aka.ms/new-console-template for more information
// using System.Data;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Hello, World!");
// Console.WriteLine("This is a demo program.");
// Console.WriteLine("Enjoy coding!");



// int x = 2;
// Console.WriteLine(x);


// string s=Console.ReadLine();
// Console.WriteLine(s);

// double x =double.Parse(Console.ReadLine());
// Console.WriteLine(x);

// int x =Convert.ToInt32(Console.ReadLine());
// int y =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(x+y);



// int num=6;
// bool isValid = true;
// for(int i= 2; i < num; i++)
// {
//     if (num % 2 == 0)
//     {
//         isValid=false;
//         break;
//     }
//     else
//     {
//         isValid=true;
//     }
// }
// if (isValid)
// {
//     Console.WriteLine("Number is prime") ;
// }else
// {
//     Console.WriteLine("Number is not prime");   
// }

// int a, b;
//         char op;

//         a = int.Parse(Console.ReadLine());
//         op = char.Parse(Console.ReadLine());
//         b = int.Parse(Console.ReadLine());

//         switch (op)
//         {
//             case '+':
//                 Console.WriteLine(a + b);
//                 break;

//             case '-':
//                 Console.WriteLine(a - b);
//                 break;

//             case '*':
//                 Console.WriteLine(a * b);
//                 break;

//             case '/':
//                 Console.WriteLine(a / b);
//                 break;
//         };    



// for (int i=0;i<9;i++)
// {
//     if (i == 4)
//     {
//         Console.WriteLine(" ");

//     }
//     else
//     {
//         Console.WriteLine("*");
//     }
// }
// using system;

// class program
// {
//     static void Main(string[] args)
//     {
//         int n=101;
//         int decimal=0;
//         int base=1;

//         while (n > 0)
//         {
//           int r= n%10;
//         n=n/10;
//         decimal+=r*base;
//         base=base*2;
// }
// Console.WriteLine("the decimal number is "+decimal );

        



//     }
// }
        



// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a binary number: ");
//         int binaryNumber = int.Parse(Console.ReadLine());
//         int decimalValue = 0;
//         int baseValue = 1;

//         while (binaryNumber > 0)
//         {
//             int remainder = binaryNumber % 10;
//             binaryNumber = binaryNumber / 10;
//             decimalValue += remainder * baseValue;
//             baseValue = baseValue * 2;
//         }

//         Console.WriteLine("Decimal Value: " + decimalValue);
//     }
// }


// using System;

// class program
// {
//     public virtual void add(int a , int b)
//     {
//       Console.WriteLine("The sum of two numbers is {0}", a + b);

//     }

//     public virtual void add(int a ,int b, int c)
//     {
//         Console.WriteLine("the sum of three numbers is {0}",a+b+c);
//     }

// }


// class demo
// {
//     static void Main()
//     {
//         program p= new program();
//         p.add(2,3);

        
        

//       p.add(2,3,4);

//       sample s =new sample();
//       s.add(2,5);



//     }
// }


// class sample : program
// {
//     public override void add(int a , int b)
//     {
//         Console.WriteLine("the sum of two numbers is {0}",a+b);
//     }
// }






using System;
class program
{
    static void Main()
    {
        Console.Write("enter a binary number :");
        int binary = int.Parse(Console.ReadLine());
        int d = 0;
        int b = 1;

        while (binary > 0)
        {
            int remainder =binary%10;
            binary =binary /10;
            d+=remainder*b;
            b=b*16;
            
        }
        Console.WriteLine("the decimal number is "+d);


    }
}



// using System;

// namespace EmployeeManagement
// {
//     class Employee
//     {
//         public string Name { get; set; }
//         public int Eid { get; set; }

//         public virtual void DisplayDetails()
//         {
//             Console.WriteLine($"ID: {Eid}");
//             Console.WriteLine($"Name: {Name}");
//         }
//     }

//     class Manager : Employee
//     {
//         public string Department { get; set; }

//         public override void DisplayDetails()
//         {
//             base.DisplayDetails();
//             Console.WriteLine($"Department: {Department}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Manager mgr = new Manager();
            
//             mgr.Eid = 101;
//             mgr.Name = "Jane Doe";
//             mgr.Department = "Information Technology";

//             Console.WriteLine("--- Manager Details ---");
//             mgr.DisplayDetails();
            
//             Console.ReadLine();
//         }
//     }
// }