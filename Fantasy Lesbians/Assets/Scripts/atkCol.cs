using UnityEngine;
using System.Collections;

public class atkCol : MonoBehaviour {

    public GameObject playerFight;
    public pawnClass pawnAtk;
    public archerClass archerAtk;
    public KennedyClass playerAtk;
    public BasicCombat bc;

    public enemyMove em;

    void Start()
    {
        playerFight = GameObject.FindGameObjectWithTag("Player");
        pawnAtk = GetComponent<pawnClass>();
        archerAtk = GetComponent<archerClass>();
        playerAtk = GetComponent<KennedyClass>();
        bc = GetComponent<BasicCombat>();
        
    }
    void OnTriggerEnter2D(Collider2D THIAC)
    {
        Debug.Log("we're in");
        if (THIAC.gameObject == playerFight)
        {
            bc.Attack();
            Debug.Log("puncha those buns");
        }
    }
}
