using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class BasicCombat : MonoBehaviour
{

    public KennedyClass playerK;
    public pawnClass pawn;
    public archerClass archer;

    // Use this for initialization
    void Start()
    {

        playerK = GetComponent<KennedyClass>();
        pawn = GetComponent<pawnClass>();
        archer = GetComponent<archerClass>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {
        while (playerK.HP != 0)
        {
            if (gameObject.CompareTag("Pawn"))
            {
                if (pawn.pawnHP != 0)
                {
                    playerK.HP -= pawn.pawnDamage;
                    Debug.Log("Player - " + playerK.HP);
                    var option = EditorUtility.DisplayDialogComplex(
                         "Attack",
                         "Do you want to attack?",
                         "Yes",
                         "No",
                         "Exit");

                    switch (option)
                    {
                        case 0:
                            pawn.pawnHP -= playerK.atkP;
                            Debug.Log("Pawn - " + pawn.pawnHP);
                            break;                          
                        case 1:
                            //Exit loop (for now)
                            break;
                        case 2:
                            //Exit loop (for now)
                            break;
                    }
                }
            }
        }
        if (playerK.HP == 0)
        {
            Debug.Log("Player death");
        }

        else if (gameObject.CompareTag("Archer"))
        {

        }


    }
}


