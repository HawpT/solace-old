using System;
using System.Collections.Generic;

namespace solace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fill Character with test info. ");

            Dictionary<string, int> stats = new Dictionary<string, int>();
            Dictionary<string, int> skills = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> core = new Dictionary<string, Dictionary<string, int>>();

            //populate our core dict
            core["stats"] = stats;
            core["skills"] = skills;

            //populate the stats dict
            stats["strength"] = 0;
            stats["agility"] = 1;
            stats["prana"] = 2;
            stats["intelligence"] = 3;
            stats["constitution"] = 4;
            stats["charisma"] = 5;
            stats["perception"] = 6;

            //populate the skills dict
            skills["melee"] = 0;
            skills["marksmanship"] = 1;
            skills["sorcery"] = 2;
            skills["empathy"] = 3;
            skills["engineering"] = 4;
            skills["smithing"] = 5;
            skills["trade"] = 6;
            skills["fortitude"] = 7;
            skills["piloting"] = 8;
            skills["ride"] = 9;
            skills["stealth"] = 10;
            skills["survival"] = 11;
            skills["tactics"] = 12;
            skills["resilience"] = 13;
            skills["performance"] = 14;
            skills["intimidate"] = 15;
            skills["persuasion"] = 17;
            skills["secondsight"] = 18;
            skills["scholarship"] = 19;
            skills["athletics"] = 20;

            int testmax = 500;
            int testvalue = 10;
            double testmod = -46.5;
            Character aphyxia = new Character(core);

            aphyxia.setValue("stats", "strength", 10);
            Console.Write("Stats should be 10: " + testvalue + " and is: " + aphyxia.getValue("stats","strength") + "\n");

            aphyxia.setMaxHealth(500);
            Console.Write("Max health should be: " + testmax + " and is: " + aphyxia.getMaxHealth() + "\n");

            aphyxia.modHealth(-46.5);
            Console.Write("Current health should be: " + (testmax + testmod) + " and is: " + aphyxia.getHealth() + "\n");

            Console.Read();

        }
    }
}
