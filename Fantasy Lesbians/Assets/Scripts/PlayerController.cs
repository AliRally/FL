using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector2 pos;
    private bool isMoving = false;
    public bool wallLeft = false;
    public bool wallRight = false;
    public bool wallUp = false;
    public bool wallDown = false;



	// Use this for initialization
	void Start () {
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        CheckInput();

        if (isMoving)
        {
            transform.position = pos;
            isMoving = false;
        }
	}

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos += Vector2.right;
            isMoving = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && wallLeft == false)
        {
            pos -= Vector2.right;
            isMoving = true;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos += Vector2.up;
            isMoving = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos -= Vector2.up;
            isMoving = true;
        }
    }
}
