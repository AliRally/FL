using UnityEngine;
using System.Collections;

public class SortingOrder : MonoBehaviour 
{

    private SpriteRenderer render;
    private float current;
    private float reverse;

	// Use this for initialization
	void Start () 
    {
        render = this.gameObject.GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update () 
    {

        current = this.gameObject.transform.position.y;
        reverse = current *= -1;

        render.sortingOrder = (int) reverse;

        if (Input.GetKey(KeyCode.O))
            Debug.Log(render.sortingOrder);
	
	}
}
