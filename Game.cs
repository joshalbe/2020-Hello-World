using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("The Crusade needs you! What is thy name?");
            string name = Console.ReadLine();

            bool choosing = true;
            char input = '0';
            string role = "";

            //This variable is used to store health
            float health = 100.0f;
            //this stores damage
            float damage = 10.0f;
            //this stores defense
            float defense = 10.0f;
            //this stores faith, the "mana" of this game
            float faith = 10.0f;
            //this stores aggro, which is the initiative/aggro stat
            float aggro = 1.0f * ((damage / 2) + defense + (faith/4));

            while (choosing)
            {
                Console.Clear();
                Console.WriteLine("Glorious! Now choose your purpose in the army!");
                Console.WriteLine("Press 1 for tank");
                Console.WriteLine("Press 2 for dps");
                Console.WriteLine("Press 3 for support");
                Console.WriteLine("Press 4 for healer");
                input = Console.ReadKey().KeyChar;
                Console.Clear();

                Console.WriteLine("Are you sure of this?");
                char ans = Console.ReadKey().KeyChar;
                if (ans == 'y')
                {
                    choosing = false;
                }
            }

            //
            if (input == '1')
            {
                health = 120.0f;
                damage = 20.0f;
                defense = 30.0f;
                faith = 10.0f;
                aggro = 1.0f * ((damage / 2) + defense + (faith / 4));
                role = "Paladin";
            }
            else if (input == '2')
            {
                health = 100.0f;
                damage = 50.0f;
                defense = 10.0f;
                faith = 20.0f;
                aggro = 1.0f * ((damage / 2) + defense + (faith / 4));
                role = "Templar";
            }
            else if (input == '3')
            {
                health = 120.0f;
                damage = 20.0f;
                defense = 20.0f;
                faith = 30.0f;
                aggro = 1.0f * ((damage / 2) + defense + (faith / 4));
                role = "Cleric";
            }
            else if (input == '4')
            {
                health = 120.0f;
                damage = 10.0f;
                defense = 10.0f;
                faith = 40.0f;
                aggro = 1.0f * ((damage / 2) + defense + (faith / 4));
                role = "Bishop";
            }


            //This value is used to heal the player
            //float healthRegen = 20.0f;

            //bool maxLevelReached = false;
            //int maxLevel = 100;
            int level = 1;
            //bool ready = true;
            Console.Clear();
            //Displays the character's stats
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Level: " + role + " " + level);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Armor: " + defense);
            Console.WriteLine("Faith: " + faith);
            Console.WriteLine(aggro);


            //create an application that gets the user's name along with an additional input
            //print the user's name and input to the console along with their stats. Must use all data types

            
        }
    }
}
