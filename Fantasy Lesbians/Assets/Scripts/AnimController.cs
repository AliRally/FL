using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

    public Animator anim;
    float tempTime = 0;
    float occTime = 0;
    float oldPosX;
    float oldPosY;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();

        oldPosX = transform.position.x;
        oldPosY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //walk and idle back
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && GetComponent<GridMove>().isMoving == false)
        {
            anim.SetBool("back", true);
            anim.SetBool("right", false);
            anim.SetBool("front", false);
            anim.SetBool("left", false);
        }

        //walk and idle left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && GetComponent<GridMove>().isMoving == false)
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
            anim.SetBool("front", false);
            anim.SetBool("back", false);
        }

        //walk and idle front
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && GetComponent<GridMove>().isMoving == false)
        {
            anim.SetBool("front", true);
            anim.SetBool("back", false);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

        //walk and idle right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && GetComponent<GridMove>().isMoving == false)
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
            anim.SetBool("front", false);
            anim.SetBool("back", false);
        }

        //ismoving walk
        if (GetComponent<GridMove>().isMoving == true)
        {
            anim.SetBool("walk", true);
        }
        if (GetComponent<GridMove>().isMoving == false)
        {
            anim.SetBool("walk", false);
        }

        //oldpos walk
        //if (oldPosX < transform.position.x || oldPosX > transform.position.x || oldPosY < transform.position.y || oldPosY > transform.position.y)
        //{
            //anim.SetBool("walk", true);
            //oldPosX = transform.position.x;
            //oldPosY = transform.position.y;

        //}

        //controll occasional

        tempTime += Time.deltaTime;

        if (tempTime >= 10f && anim.GetBool("occ") == false)
        {
            var number = Random.Range(1,3);
            Debug.Log(number);
            if (number == 1)
            {
                anim.SetBool("occ", true);
                //occTime += Time.deltaTime;
            }
            
            //tempTime = 0;
        }

        if (anim.GetBool("occ") == true)
        {
            if (occTime >= 2f)
            {
                anim.SetBool("occ", false);
                tempTime = 0;
                occTime = 0;
            }
            else
            {
                occTime += Time.deltaTime;
            }
        }

    }
}
