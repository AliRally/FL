using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    private Vector3 pos;
    private Vector3 endpos;
    private float gridSize = 64f;
    private float moveSpeed = 128f;

    bool lerp;

    public bool isMoving = false;

    public bool wallLeft = false;
    public bool wallRight = false;
    public bool wallUp = false;
    public bool wallDown = false;

    private float factor, t;

    GridMove GM = new GridMove();

	// Use this for initialization
	void Start () 
    {
        pos = transform.position;
        //endpos = transform.position;
        lerp = false;
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (lerp)
        {
            GM = this.GetComponent<GridMove>();
            GM.move(transform);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && wallRight == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x += gridSize, pos.y, 0);
            lerp = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && wallLeft == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x -= gridSize, pos.y, 0);
            lerp = true;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && wallUp == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x, pos.y += gridSize, 0);
            lerp = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && wallDown == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x, pos.y -= gridSize, 0);
            lerp = true;
        }
	}
}
