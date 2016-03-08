using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solace
{
    
    class GameAction
    {
        //class variables
        private static int currentID { get { return currentID; } set { currentID = value; } }
        private int actionID { get { return actionID; } set { actionID = value; } }
        private string actionName { get { return actionName; } set { actionName = value; } }

        //default constructor
        public GameAction() {
            actionName = "Unamed Action";
            currentID += 1;
            actionID = currentID;
        }

        //Name is the only modable field, ID's are assigned automatically
        public GameAction(string newName)
        {
            actionName = newName;
            currentID += 1;
            actionID = currentID;
        }

        //initialize static variable, called before any other constructor
        static GameAction()
        {
            currentID = 0;
        }
    }
}
