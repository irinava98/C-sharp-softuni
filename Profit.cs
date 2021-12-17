using System;
namespace Profit
{
    public class Profit
    {
        static void Main(string[]args)
        {
            int countOne=int.Parse(Console.ReadLine());
            int countTwo=int.Parse(Console.ReadLine());
            int countFive=int.Parse(Console.ReadLine());
            int sum=int.Parse(Console.ReadLine());
            
            
            for(int i=0;i<=countOne;i++)
            {
                for(int j=0;j<=countTwo;j++)
                {
                    for(int k=0;k<=countFive;k++)
                    {
                        if(i*1+j*2+k*5==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
            
        }
    }
}