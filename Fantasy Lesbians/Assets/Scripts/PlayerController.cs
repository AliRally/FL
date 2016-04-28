using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    private Vector3 pos;
    private Vector3 endpos;
    private Vector2 input;
    private float gridSize = 64f;
    private float moveSpeed = 128f;
    private bool allowDiagonals = false;
    private bool correctDiagonalSpeed = true;

    bool lerp;

    public bool isMoving = false;

    public bool wallLeft = false;
    public bool wallRight = false;
    public bool wallUp = false;
    public bool wallDown = false;

    private float factor;
    public float t;

    GridMove GM = new GridMove();

	
    //void Start () 
    //{
    //    pos = transform.position;
    //}
	
	void Update () 
    {
        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && wallRight == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x += gridSize, pos.y, 0);
            StartCoroutine(move(transform));
            input.y = 0;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && wallLeft == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x -= gridSize, pos.y, 0);
            StartCoroutine(move(transform));
            input.y = 0;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && wallUp == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x, pos.y += gridSize, 0);
            StartCoroutine(move(transform));
            input.x = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && wallDown == false)
        {
            pos = transform.position;
            endpos = new Vector3(pos.x, pos.y -= gridSize, 0);
            StartCoroutine(move(transform));
            input.x = 0;
        }

	}

    public IEnumerator move(Transform transform)
    {
        Debug.Log("zhu li does the thing");

        isMoving = true;
        t = 0;

        if (allowDiagonals && correctDiagonalSpeed && input.x != 0 && input.y != 0)
        {
            factor = 0.7071f;
        }
        else
        {
            factor = 1f;
        }

        while (t < 1f)
        {
            Debug.Log("we do the lerp");
            t += Time.deltaTime * (moveSpeed / gridSize) * factor; Debug.Log(t);
            transform.position = Vector3.Lerp(pos, endpos, t);
            yield return null;
        }

        isMoving = false;
        lerp = false;
        yield return 0;
    }
}
