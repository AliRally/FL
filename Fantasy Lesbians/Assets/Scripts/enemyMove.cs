using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {

    public Transform Character; // Target Object to follow
    public float speed = 0.1F; // Enemy speed
    public Vector3 directionOfCharacter;

   // public EnemyCollision ec;

	// Use this for initialization
	void Start () {

        Character = GameObject.FindGameObjectWithTag("Player").transform;
       // ec = GetComponent<EnemyCollision>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        
	}

    public void Follow()
    {
        directionOfCharacter = Character.transform.position - transform.position;
        directionOfCharacter = directionOfCharacter.normalized;    // Get Direction to Move Towards
        transform.Translate(directionOfCharacter * speed, Space.World);
    }
}
