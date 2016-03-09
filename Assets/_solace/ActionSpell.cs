using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solace
{
    public class ActionSpell : GameAction
    {
        private int spellRange { get { return spellRange; } set { spellRange = value; } }
        private int spellArea { get { return spellArea; } set { spellArea = value; } }
        private int spellValue { get { return spellValue; } set { spellValue = value; } }
        private static int currentID { get { return currentID; } set { currentID = value; } }
        private int actionID { get { return actionID; } set { actionID = value; } }
        private string actionName { get { return actionName; } set { actionName = value; } }

        //category and attribute being affected by the spell
        private string spellTargetAttribute { get { return spellTargetAttribute; } set { spellTargetAttribute = value; } }
        private string spellTargetCategory { get { return spellTargetCategory; } set { spellTargetCategory = value; } }

        //defaults to modifying health
        public ActionSpell(string newname)
        {
            actionName = newname;
        }

        public ActionSpell(string newName, int range, int area, int value)
        {
            actionName = newName;
            spellRange = range;
            spellArea = area;
            spellValue = value;
            spellTargetCategory = "general";
            spellTargetAttribute = "health";
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
        }

    }
}
