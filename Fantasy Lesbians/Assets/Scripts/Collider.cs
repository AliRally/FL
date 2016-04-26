using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour 
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("enter");

        if (col.CompareTag("left wall"))
        {
            Debug.Log("i see a little sillouetto of a man");
            GetComponent<PlayerController>().wallLeft = true;
            Debug.Log("left");
        }
        else if (col.CompareTag("right wall"))
        {
            GetComponent<PlayerController>().wallRight = true;
        }
        else if (col.CompareTag("up wall"))
        {
            GetComponent<PlayerController>().wallUp = true;
        }
        else if (col.CompareTag("down wall"))
        {
            GetComponent<PlayerController>().wallDown = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("left wall"))
        {
            GetComponent<PlayerController>().wallLeft = false;
        }
        else if (col.CompareTag("right wall"))
        {
            GetComponent<PlayerController>().wallRight = false;
        }
        else if (col.CompareTag("up wall"))
        {
            GetComponent<PlayerController>().wallUp = false;
        }
        else if (col.CompareTag("down wall"))
        {
            GetComponent<PlayerController>().wallDown = false;
        }
    }

}
