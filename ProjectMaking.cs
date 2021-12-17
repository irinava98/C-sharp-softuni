using System;

namespace Project
{
    class ProjectMaking
    {
        static void Main(string [] args)
        {
            string name=Console.ReadLine();
            int numberprojects=int.Parse(Console.ReadLine());
            int hours=numberprojects*3;
            string result=$"The architect {name} will need {hours} hours to complete {numberprojects} project/s.";
            Console.WriteLine(result);
        }
    }
    
}