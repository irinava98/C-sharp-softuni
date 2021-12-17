using System;
namespace ReadText 
{
    public class ReadText 
    {
        static void Main(string[]args)
        {
          while(true)
          {
              string input=Console.ReadLine();
              if(input=="Stop")
              {
                  break;
              }
              Console.WriteLine(input);
          }
        }
    }
}