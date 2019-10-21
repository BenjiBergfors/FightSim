using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();

            Fighter f2 = new Fighter();

            f1.name = Console.ReadLine();

            f2.name = Console.ReadLine();

            f1.hp = 100;
            f2.hp = 100;

            f1.Attack();
            f2.Attack();
            f1.Hurt(f1.hp -= f2.Attack());
            f2.Hurt(f2.hp -= f1.Attack());
            f1.GetHp = (f1.hp -= f2.Attack());
            f2.GetHp = (f2.hp -= f1.Attack());

            Console.WriteLine("Welcome to this Fighting Game!");
            Thread.Sleep(750); // Gör så att "[Click Enter]" kommer 750 millisekunder efter "Welcome to this Fighting Game!"
            Console.WriteLine("[Click Enter]");
            Console.ReadLine();

            Console.WriteLine("Name your character");

            f1.name = Console.ReadLine();

            while (f1.name.Length < 2)
            {
                Console.WriteLine("Dumbass. Can't have less than 2 letters in your name. Write a new name.");

               f1.name = Console.ReadLine();
            }


            Console.WriteLine("Name your opponent");

            f2.name = Console.ReadLine();

            while (f2.name.Length < 2)
            {
                Console.WriteLine("Dumbass. Can't have less than 2 letters in your name. Write a new name.");

                f1.name = Console.ReadLine();
            }
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine(">>>>>>>>>>>>>> " + f1.name + " vs " + f2.name + " <<<<<<<<<<<<<<");
            Console.WriteLine("____________________________________________________________");

            Thread.Sleep(750); // Thread.Sleep gör så att en Console.Writeline tar längre tid på sig att ploppa up, i detta fall så
            // kommer "[Click Enter]" 750 millisekunder efter name1 + " vs " + name2.
            Console.WriteLine("[Click Enter]");
            Console.ReadLine();

            Console.WriteLine("3");
            Thread.Sleep(750);

            Console.WriteLine("2");
            Thread.Sleep(750);

            Console.WriteLine("1");
            Thread.Sleep(750);
            Console.WriteLine("Start!");
            
            
            while (f1.hp > 0 && f2.hp > 0)
            {
                f1.IsAlive = true;
                f2.IsAlive = true;






                Console.WriteLine(f1.name + " deals " + f1.Attack() + " damage against " + f2.name);
                Thread.Sleep(1000);
                Console.WriteLine(f2.name + " deals " + f2.Attack() + " damage against " + f1.name);

                f2.Hurt(f1.hp -= f2.Attack());
                f1.Hurt(f1.hp -= f2.Attack());
                f1.GetHp = f1.hp;
                f2.GetHp = f2.hp;
                Thread.Sleep(1000);

                Console.WriteLine(f1.name + " have " + f1.GetHp + " HP left and " + f2.name + " have " + f2.GetHp + " HP left");
                Thread.Sleep(1000);
            }


            if (f1.hp == 0 || f1.hp < 0) // Denna visar att om Player2 har mer HP kvar än Player1 så står det att player2's namn har vunnit
                                   // och visar hur mycket HP spelaren som vann har kvar
            {
                f1.IsAlive = false;
                Console.WriteLine(f2.name + " you won! *Clap Clap Clap Clap* and you have " + f2.GetHp + " HP left");
            }




            if (f2.hp == 0 || f2.hp < 0) // Om player2 inte har mer HP kvar än player1 så gör denna else att det kommer upp att Player1 har vunnit
            // och visar hur mycket HP player 1 har kvar efter vinsten.
            {
                f2.IsAlive = false;
                Console.WriteLine(f1.name + " you won! *Clap Clap Clap Clap* and you have " + f1.GetHp + " HP left");


            }

            if (f1.hp == 0 && f2.hp == 0) // Ifen visar att om player1 och player2 har lika mycket HP kvar så visar det att det blev lika.
            {
                Console.WriteLine("It's a tie!");
            }
            Console.WriteLine("Thank you for playing this game");

            Console.ReadLine();


        }
    }
}
