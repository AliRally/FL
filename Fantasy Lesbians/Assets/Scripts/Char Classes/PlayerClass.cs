using UnityEngine;
using System.Collections;
using System.Timers;

public class PlayerClass : MonoBehaviour 
{
    public int HP;
    public int maxHP;
    public int atkP;
    public bool Dash = false;
    public bool isAttacking = false;
    public bool isInCombat = false;

    static Timer timer = new Timer(3000);

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void Healing()
    {
        //timer.Start(); 
         
    }

   
}
