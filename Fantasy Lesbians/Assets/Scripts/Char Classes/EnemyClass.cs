using UnityEngine;
using System.Collections;

public class EnemyClass : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float attack1Range = 1f;
    public int pawnDamage = 2;
    public float timeBetweenAttacks;
    public int pawnHP = 10;

    // Use this for initialization
    void Start()
    {
        Rest();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move()
    {
        transform.LookAt(target.position);
        transform.Rotate(new Vector2(0, -90), Space.Self);

        if (Vector2.Distance(transform.position, target.position) > attack1Range)
        {
            
        }
    }

    public void Rest()
    {

    }
}
