using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("no. 1");
         Console.Write("Enter first no.: ");
         int first = int.Parse(Console.ReadLine());
         Console.Write("Enter second no.: ");
         int second = int.Parse(Console.ReadLine());
         Console.WriteLine("The numbers devisible by 5 without remainder from {0} to {1} are: ",first,second);
         for (int i = first; i <= second; i++)
         
          if (i % 5 == 0)
         {
          Console.WriteLine(i);
         } 
         
          
         Console.WriteLine();

          Console.WriteLine("no. 2");
         int firstN = 0; 
         int secondN = 1;
         int thirdN = 0;

         int length = 100;
         Console.WriteLine("The first 100 numbers of the fibonnaci sequence are");

         Console.Write("0, 1,");

         for(int i = 2; i < length; i++)
         {
          thirdN = firstN + secondN;
          Console.Write(" {0},", thirdN);
          firstN = secondN;
          secondN = thirdN;
          }
         Console.WriteLine();
          


         Console.WriteLine("no. 3");
         Console.Write("Type number 1:");   
          int a = int.Parse(Console.ReadLine());
         Console.Write("Type number 2:");   
          int b = int.Parse(Console.ReadLine());
         Console.Write("Type number 3:");    
         int c = int.Parse(Console.ReadLine());
         Console.Write("Type number 4:");    
         int d = int.Parse(Console.ReadLine());
         Console.Write("Type number 5:");    
         int e = int.Parse(Console.ReadLine());

         
         int max;
          if (a > b && a > c && a > d && a > e)
         {
         max = a;
          Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
         }
          else if (b > a && b > c && b > d && b > e)
         {
         max = b;
          Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
         }
         
          else if (c > a && c > b && c > d && c > e)
         {
          max = c;
          Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
         }
         
          else if (d > a && d > b && d > c && d > e)
         {
          max = d;
          Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
         }
         
          else if (e > a && e > b && e > c && e > d)
         {
          max = e;
          Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
         }

         Console.WriteLine();


         Console.WriteLine("no. 4");
         Console.WriteLine("Calculate root of Quadratic Equation : ");
         Console.WriteLine("Input the value of a : ");
         int a1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Input the value of b : ");
         int b2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Input the value of c : ");
         int c3 = Convert.ToInt32(Console.ReadLine());

         double discriminant = b2*b2-4*a1*c3;
         if(discriminant == 0)
          {
         Console.WriteLine("Equation has one double real roots");
         double root1 = -b2/(2*a1);
         double root2 = -b2/(2*a1);
         Console.Write($"First  Root= {root1}");
          Console.Write($"Second Root= {root2}");
          }
         else if(discriminant>0)
        	{
	       Console.Write("The real roots are: ");

	       double root1 = (-b2+Math.Sqrt(discriminant))/(2*a1);
	       double root2 = (-b2-Math.Sqrt(discriminant))/(2*a1);

	       Console.Write($"First  Root = {root1}");
	       Console.Write($"Second Root = {root2}");
        	}
        	else
          {
	       Console.Write("Equation has no real root");
          }
          Console.WriteLine(); 



         Console.WriteLine("no. 6");
         Console.Write("Enter N: ");
         int length2 = Int32.Parse(Console.ReadLine());

         for (int i = 1; i < length2; i++)
            
         if (i % 3 * 7 == 0 )
         {
          Console.WriteLine(i); 
         }
         Console.WriteLine();

         


         Console.WriteLine("no. 8");
          int firstNo = 0; 
         int secondNo = 1;
         int thirdNo = 0;
          Console.Write("Enter Number: ");
         int length1 = Int32.Parse(Console.ReadLine());

         Console.WriteLine($"The first {length} numbers of the fibonnaci sequence are");

         Console.Write("0, 1,");

         for(int i = 2; i < length1; i++)
         {
          thirdNo = firstNo + secondNo;
          Console.Write(" {0},", thirdNo);
          firstNo = secondNo;
          secondNo = thirdNo;
         }
         Console.WriteLine();

         


         


         Console.WriteLine("no. 11");
         int[] arr = new int[20];

         for (int i = 0; i < arr.Length; i++)
         {
          arr[i] = i * 5;
          Console.WriteLine(arr[i]);
         }
         Console.WriteLine();
         



         Console.WriteLine("no. 14");
          Console.Write("Enter decimal number: ");
         int deci = Int32.Parse(Console.ReadLine());
         
         string bina = Convert.ToString(deci, 2);
         Console.WriteLine($"{deci} to binary is {bina}.");
          Console.WriteLine();

         
         Console.WriteLine("no. 15");
         
        
         Console.Write("Enter binary number: ");
         string binary = Console.ReadLine();
         int dec = Convert.ToInt32(binary, 2);
          Console.WriteLine($"{binary} to decimal is {dec}.");
          Console.WriteLine();


         Console.WriteLine("no. 16");
         Console.Write("Enter decimal number: ");
         int decim = Int32.Parse(Console.ReadLine());
         
         string hexadec = Convert.ToString("X");
         Console.WriteLine($"{decim} to hexadecimal is {hexadec}.");
          Console.WriteLine();

         Console.WriteLine("no. 17");
         Console.Write("Enter hexadecimal number: ");
         string hexa = Console.ReadLine();
         int decima = Convert.ToInt32(hexa, 16);
         Console.WriteLine($"{hexa} to decimal is {decima}."); 
          Console.WriteLine();

         Console.WriteLine("no. 18");
          Console.Write("Enter hexadecimal number: ");
          string hexad = Console.ReadLine();

          string bin = Convert.ToString(Convert.ToInt32(hexad, 16), 2);
          Console.WriteLine($"{hexad} to binary is {bin}.");
           Console.WriteLine();
         
         
         Console.WriteLine("no. 19");
         Console.WriteLine("Enter binary number: ");
         string binaryNo = Console.ReadLine();
         string hex = Convert.ToInt32(binaryNo, 2).ToString("X");
         Console.WriteLine($"{binaryNo} to hexadecimal is {hex}.");
         Console.WriteLine();
         



         
         



         

     



         









        }
    }
}
