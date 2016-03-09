using System.Collections.Generic;
using System;

namespace solace
{
    public class Character
    {
        //Dictionary of Dictionaries, keys are string names of each category of attribute
        private Dictionary<string, Dictionary<string, int>> coreDict; 
        //Other class variables
        private string[] attributes;
        private int level;
        private double health, maxHealth;
        private string name;
        public static Dictionary<string,Character> allCharacters;
        


        /*
        * CONSTRUCTORS
        */
        //static constructor
        static Character()
        {
            //max player character count limited to 10
            allCharacters = new Dictionary<string, Character>();
        }

        //default constuctor
        public Character(string newName)
        {
            name = newName;
            coreDict = new Dictionary<string, Dictionary<string, int>>();
            health = 10;
            if (allCharacters[name] != null)
                Console.WriteLine("Character with that name already exists!");
            else
                allCharacters[name] = this;
        }

        public Character(Dictionary<string, Dictionary<string, int>> importedDict, string newName)
        {
            coreDict = importedDict;
            name = newName;
            health = 10;
            if (allCharacters[name] != null)
                Console.WriteLine("Character with that name already exists!");
            else
                allCharacters[name] = this;
        }

        /*
        * ACCESSORS
        */
        //accessor for all attribute names
        public string[] getAttributeTypes(){ return attributes; } 

        //accessor that returns the dictionary of key/value pairs in a given attribute category
        public Dictionary<string, int> getValuesByCategory(string category)
        {
            try {
                var save = coreDict[category];
                return save;
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }

        //accessor that returns a single attribute value given a category and attribute name, returns -1 if not found
        public int getValue(string category, string attribute) {
            try
            {
                var save = (coreDict[category])[attribute];
                return save;
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
        
        //accessor for character name
        public string getName() { return name; }

        //accessor for current health
        public double getHealth() { return health; }

        //accessor for max health
        public double getMaxHealth() { return maxHealth; }


        /*
        * MUTATORS
        */
        //mutator for single values given a category and attribute name
        public void setValue(string category, string attribute, int newValue) { (coreDict[category])[attribute] = newValue; return; }

        //mutator for setting a characters level
        public void setLevel(int newLevel)
        {
            if (newLevel > 0)
                level = newLevel;
        }

        //mutator for adding or subtractign health
        public void modHealth(double changeInHealth) { health += changeInHealth; }

        //mutator for changing a characters max health
        public void setMaxHealth(double newMaxHealth) { maxHealth = newMaxHealth; }


        /*
        * METHODS
        *
        public void takeAction(GameAction action)
        {
            takeAction(action, this);
        }

        public void takeAction(GameAction action, Character targetOfAction)
        {

        }
        /**/
         

       
        //overrided tostring
        public override string ToString()
        {
            return "Character name: " + name + "\nCharacter level: " + level;
        }


    }
}
