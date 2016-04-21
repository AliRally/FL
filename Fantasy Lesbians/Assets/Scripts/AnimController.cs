using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

    public Animator anim;
    float tempTime = 0;
    float occTime = 0;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        //walk and idle back
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("back", true);
            anim.SetBool("right", false);
            anim.SetBool("front", false);
            anim.SetBool("left", false);
            anim.SetBool("walk", true);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("walk", false);
        }

        //walk and idle left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
            anim.SetBool("front", false);
            anim.SetBool("back", false);
            anim.SetBool("walk", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("walk", false);
        }

        //walk and idle front
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("front", true);
            anim.SetBool("back", false);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("walk", true);
        }

        if (Input.GetKeyUp(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("walk", false);
        }

        //walk and idle right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
            anim.SetBool("front", false);
            anim.SetBool("back", false);
            anim.SetBool("walk", true);
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("walk", false);
        }

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
            if (occTime >= 1f)
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
