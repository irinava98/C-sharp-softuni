using System;
namespace Rage
{
    public class Rage
    {
        static void Main(string[]args)
        {
            int lostGames=int.Parse(Console.ReadLine());
            double headPrice=double.Parse(Console.ReadLine());
            double mousePrice=double.Parse(Console.ReadLine());
            double keyboardPrice=double.Parse(Console.ReadLine());
            double displayPrice=double.Parse(Console.ReadLine());


            int countTrashHeadset=lostGames/2;
            int countTrashMouse=lostGames/3;
            int countTrashKeyboard=lostGames/6;
            int countTrashDisplay=lostGames/12;

            double price=countTrashHeadset*headPrice+countTrashMouse*mousePrice+countTrashKeyboard*keyboardPrice+countTrashDisplay*displayPrice;
            Console.WriteLine($"Rage expenses: {price:F2} lv.");



        }
    }
}