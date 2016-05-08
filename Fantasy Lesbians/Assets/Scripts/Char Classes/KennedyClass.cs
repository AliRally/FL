using UnityEngine;
using System.Collections;

public class KennedyClass : PlayerClass 
{
   
    
	// Use this for initialization
	void Start () 
    {
       HP = 16;
       maxHP = 16;
       atkP = 2;
       Dash = false;
       isAttacking = false;
       isInCombat = false;

	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(isInCombat == false)
        {
            Healing();
        }
	}
}
