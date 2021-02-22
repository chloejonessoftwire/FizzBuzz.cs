using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzC_
{
    class Program
    {
        public String FizzBuzz(int max)
            {   
            //    Console.Write('Enter the maximum integer');
            //    int max= Console.ReadLine();
                for (int i=1;i<=max;i++)
                {List<String> output = new List<string>(){};
                    if (i%13==0)
                    {
                        output.Add("Fezz");
                    }
                    if (i%11==0){
                        output.Add("Bong");
                        if (i%17==0)
                        {
                            output.Reverse();
                        }
                        string xresult=string.Join(", ", output);
                        Console.WriteLine(xresult);
                        continue;
                        }
                    if (i%3==0)
                    {
                        output.Add("Fizz");
                    }
                    if (i%5==0)
                    {
                        output.Add("Buzz");
                    }
                    if (i%7==0)
                    {
                        output.Add("Bang");
                    }
                    if (i%17==0){
                        output.Reverse();
                    }
                    if (i%11!=0 && i%3!=0 && i%5!=0 && i%7!=0&& i%13!=0) 
                    {
                    output.Add(Convert.ToString(i));
                    }
                    string result=String.Join(",", output);
                    Console.WriteLine(result);
                };
 
                return ("Done");
            }
        static void Main(string[] args)
        {   
            
            Program p = new Program();
            p.FizzBuzz(255);
      
        }
    }
}
