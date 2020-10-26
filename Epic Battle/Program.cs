using System;
using System.Security.Cryptography.X509Certificates;

namespace Epic_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Artem", "captain Price", "Lara Croft", "Commander.Felix Riley" };
            string[] villains = { "Voldemort", "General Korbut", "Vladimir Makarov", "Darth Wader", "Valeria Phoenix" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);

           


            int heroHP = GenerateHP();
            int villainHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} with" + $"{villainHP} HP");
            while(heroHP > 0 && villainHP > 0)
            {
                Random rnd = new Random();
                heroHP = heroHP - Hit(hero);
                villainHP = villainHP - Hit(villain);
            }

              GetWinner(heroHP, villainHP);

        }


        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }
        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }

        public static int Hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if(strike == 3)
            {
                Console.WriteLine($"Awesome!{character} made a critical hit!");
               
                
            }
            else if (strike == 0)
            {
                Console.WriteLine($"Bad Luck!{character}missed the target!");
            }
            return strike;

            


        }
        public static void GetWinner(int hHP, int vHP)
            {
                if (hHP == 0)
                {
                    Console.WriteLine("Dark side wins");

                }
                else
                {
                    Console.WriteLine($"Hero saves the day!");
                }
            }

    }
}
