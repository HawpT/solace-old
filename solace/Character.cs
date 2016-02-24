using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solace
{
    public class Character
    {
        //Dictionary of Dictionaries, keys are string names of each category of attribute
        private Dictionary<string, Dictionary<string, int>> coreDict; 
        private string[] attributes;
        private int level;
        private string name;


        //default constuctor
        public Character()
        {
            coreDict = new Dictionary<string, Dictionary<string, int>>();
            name = "Not Named";
        }

        public Character(string newName)
        {
            name = newName;
            coreDict = new Dictionary<string, Dictionary<string, int>>();
        }

        //overloaded constuctor for pre-built dictionaries
        public Character(Dictionary<string, Dictionary<string, int>> importedDict)
        {
            coreDict = importedDict;
        }

        public Character(Dictionary<string, Dictionary<string, int>> importedDict, string newName)
        {
            coreDict = importedDict;
            name = newName;
        }

        //accessor for all attribute names
        public string[] getAttributeTypes(){ return attributes; } 

        //accessor that returns the dictionary of key/value pairs in a given attribute category
        public Dictionary<string, int> getValuesByCategory(string category) { return coreDict[category]; }

        //accessor that returns a single attribute value given a category and attribute name
        public int getValue(string category, string attribute) { return (coreDict[category])[attribute]; }

        //mutator for single values given a category and attribute name
        public void setValue(string category, string attribute, int newValue) { (coreDict[category])[attribute] = newValue; return; }

        //mutator for setting a characters level
        public void setLevel(int newLevel)
        {
            if (newLevel > 0)
                level = newLevel;
        }

        //overrided tostring
        public override string ToString()
        {
            return "Character name: " + name + "\nCharacter level: " + level;
        }

    }
}
