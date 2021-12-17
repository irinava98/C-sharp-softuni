using System;
namespace Report
{
    public class Report
    {
        public static void Main(string[] args)
        {
            int neededMoney=int.Parse(Console.ReadLine());

           
           
            string input=Console.ReadLine();
            int paysWithCard=0;
            int paysWithCash=0;
            int sumWithCard=0;
            int sumWithCash=0;
            int count=0;
            int currentPay=0;
            bool success=false;

            while(input!="End")
            {

             count++;
             if(count%2!=0)
             {
                 currentPay=int.Parse(input);
                 if(currentPay>100)
                 {
                     Console.WriteLine("Error in transaction!");
                 }
                 else
                 {
                     paysWithCash++;
                     sumWithCash+=currentPay;
                     
                     Console.WriteLine("Product sold!");
                 }
             }
             else
             {
                 currentPay=int.Parse(input);
                 if(currentPay<10)
                 {
                     Console.WriteLine("Error in transaction!");
                 }
                 else
                 {
                     paysWithCard++;
                     sumWithCard+=currentPay;
                     
                     Console.WriteLine("Product sold!");
                 }
             }
              if(input=="End")
             {
                 success=false;
                 break;
             }
             
             if(sumWithCash+sumWithCard>=neededMoney)
             {
                 success=true;
                 double avarageCash=sumWithCash/(double)paysWithCash;
                 double avarageCard=sumWithCard/(double)paysWithCard;

                 Console.WriteLine($"Average CS: {avarageCash:F2}");
                 Console.WriteLine($"Average CC: {avarageCard:F2}");
                 break;
             }
            
             
             input=Console.ReadLine();
            }
            if(success==false)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}