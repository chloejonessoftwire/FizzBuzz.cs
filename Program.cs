using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FizzBuzzC_
{
    class Program
    {
        public String FizzBuzz()
            {   
                Console.Write("Enter a maximum number:");
                string max= Console.ReadLine();
                Console.Write("Apply rule 3 (fizz)? [y/n]");
                string rulethree= Console.ReadLine();
                Console.Write("Apply rule 5 (buzz)? [y/n]");
                string rulefive= Console.ReadLine();
                Console.Write("Apply rule 7 (bang)? [y/n]");
                string ruleseven= Console.ReadLine();
                Console.Write("Apply rule 11 (bong)? [y/n]");
                string ruleeleven= Console.ReadLine();
                Console.Write("Apply rule 13 (fezz)? [y/n]");
                string rulethirteen= Console.ReadLine();
                Console.Write("Apply rule 17 (reverse)? [y/n]");
                string ruleseventeen= Console.ReadLine();
                int maxnum=int.Parse(max);

                for (int i=1;i<=maxnum;i++)
                {List<String> output = new List<string>(){};
                    if (i%13==0 && rulethirteen=="y")
                    {
                        output.Add("Fezz");
                    }
                    if (i%11==0 && ruleeleven=="y"){
                        output.Add("Bong");
                        if (i%17==0 && ruleseventeen=="y")
                        {
                            output.Reverse();
                        }
                        string xresult=string.Join(", ", output);
                        Console.WriteLine(xresult);
                        continue;
                        }
                    if (i%3==0 && rulethree=="y")
                    {
                        output.Add("Fizz");
                    }
                    if (i%5==0 && rulefive=="y")
                    {
                        output.Add("Buzz");
                    }
                    if (i%7==0 && ruleseven=="y")
                    {
                        output.Add("Bang");
                    }
                    if (i%17==0 && ruleseventeen=="y"){
                        output.Reverse();
                    }
                    if (!output.Any())
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
            p.FizzBuzz();
      
        }
    }
}
