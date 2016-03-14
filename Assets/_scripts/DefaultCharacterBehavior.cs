using UnityEngine;
using solace;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class DefaultCharacterBehavior : MonoBehaviour {
    private Character charObject;
    private Ray ray;
    private RaycastHit hit;
    public string characterName;
    public static Dictionary 
    //make script listen for character creation
    


    private void setCharName(string newName)
    {

    }

    // Use this for initialization
    void Start () {

        //Test values
        Dictionary<string, int> stats = new Dictionary<string, int>();
        Dictionary<string, int> skills = new Dictionary<string, int>();
        Dictionary<string, Dictionary<string, int>> core = new Dictionary<string, Dictionary<string, int>>();

        //populate our core dict
        core["stats"] = stats;
        core["skills"] = skills;

        //populate the stats dict
        stats["strength"] = 3;
        stats["agility"] = 3;
        stats["prana"] = 3;
        stats["intelligence"] = 3;
        stats["constitution"] = 3;
        stats["charisma"] = 3;
        stats["perception"] = 3;

        //populate the skills dict
        skills["melee"] = 3;
        skills["marksmanship"] = 3;
        skills["sorcery"] = 3;
        skills["empathy"] = 3;
        skills["engineering"] = 3;
        skills["smithing"] = 3;
        skills["trade"] = 3;
        skills["fortitude"] = 3;
        skills["piloting"] = 3;
        skills["ride"] = 3;
        skills["stealth"] = 3;
        skills["survival"] = 3;
        skills["tactics"] = 3;
        skills["resilience"] = 3;
        skills["performance"] = 3;
        skills["intimidate"] = 3;
        skills["persuasion"] = 3;
        skills["secondsight"] = 3;
        skills["scholarship"] = 3;
        skills["athletics"] = 3;

        //create the Character object
        charObject = new Character(core);
        Debug.Log("Character successfully Created");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    // FixedUpdate is called once every physics frame
    void FixedUpdate()
    {

    }
}
