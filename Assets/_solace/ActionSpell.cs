using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solace
{
    //inherits from empty parent class for generic purposes
    public class ActionSpell : GameAction
    {
        //class variables
        private int spellRange { get { return spellRange; } set { spellRange = value; } }
        private int spellArea { get { return spellArea; } set { spellArea = value; } }
        private int spellValue { get { return spellValue; } set { spellValue = value; } }
        private static int currentID { get { return currentID; } set { currentID = value; } }
        private int actionID { get { return actionID; } set { actionID = value; } }
        private string actionName { get { return actionName; } set { actionName = value; } }
        public static Dictionary<string, ActionSpell> allActionSpell;
        public static int currentSpellID { get { return currentSpellID; } set { currentSpellID = value; } }
        private int spellID { get { return spellID; } set { spellID = value; } }

        //category and attribute being affected by the spell
        private string spellTargetAttribute { get { return spellTargetAttribute; } set { spellTargetAttribute = value; } }
        private string spellTargetCategory { get { return spellTargetCategory; } set { spellTargetCategory = value; } }

        //static constructor
        static ActionSpell()
        {
            currentSpellID = 0;
            allActionSpell = new Dictionary<string, ActionSpell>();
        }

        //defaults to modifying health
        public ActionSpell(string newname)
        {
            actionName = newname;
            currentID += 1;
            actionID = currentID;
            if (allActionSpell[actionName] != null)
                Console.WriteLine("Character with that name already exists!");
            else
                allActionSpell[actionName] = this;
        }

        public ActionSpell(string newName, int range, int area, int value)
        {
            actionName = newName;
            spellRange = range;
            spellArea = area;
            spellValue = value;
            spellTargetCategory = "general";
            spellTargetAttribute = "health";
            currentID += 1;
            actionID = currentID;
            if (allActionSpell[actionName] != null)
                Console.WriteLine("Character with that name already exists!");
            else
                allActionSpell[actionName] = this;
        }

        public ActionSpell(string newName, int range, int area, int value, string att, string cat)
        {   

            if ((range < 0) || (area < 0))
                Console.WriteLine("Invalid spell range or area, could not initiate the instance;");
            else {
                spellRange = range;
                spellArea = area;
            }
            spellValue = value;
            spellTargetCategory = cat;
            spellTargetAttribute = att;
            currentID += 1;
            actionID = currentID;
            if (allActionSpell[actionName] != null)
                Console.WriteLine("Character with that name already exists!");
            else
                allActionSpell[actionName] = this;
        }

    }
}
