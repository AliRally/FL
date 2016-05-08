using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour 
{
    public BoxCollider2D EnemeyArea;
    public GameObject player;
    public bool playerInEA;
    public GameObject pawn;
    public GameObject archer;

    //public pawnClass pawn;
    //public archerClass archer;
  
    //public enemyMove em;


	// Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //pawn = GetComponent<pawnClass>();
        //archer = GetComponent<archerClass>();
        playerInEA = false;
	}
	
	// Update is called once per frame
	void Update () 
    {       
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject == player)
        {
            playerInEA = true;
            //em = this.GetComponent<enemyMove>();
            Debug.Log("Player enter.");
            pawn.GetComponent<enemyMove>().Follow();
            archer.GetComponent<enemyMove>().Follow();
           // em.Follow();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            Debug.Log("Player exit");
            playerInEA = false;
        }
    }
}
