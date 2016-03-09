﻿using UnityEngine;
using solace;
using System.Collections.Generic;
using System;

public class DefaultCharacterBehavior : MonoBehaviour {
    private Character charObject;
    private Ray ray;
    private RaycastHit hit;
    

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

        //create the Character object
        charObject = new Character(core,"Aphyxia");
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