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
            GetComponent<GridMove>().wallLeft = true;
            Debug.Log("left");
        }
        else if (col.CompareTag("right wall"))
        {
            GetComponent<GridMove>().wallRight = true;
        }
        else if (col.CompareTag("up wall"))
        {
            GetComponent<GridMove>().wallUp = true;
        }
        else if (col.CompareTag("down wall"))
        {
            GetComponent<GridMove>().wallDown = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("left wall"))
        {
            GetComponent<GridMove>().wallLeft = false;
        }
        else if (col.CompareTag("right wall"))
        {
            GetComponent<GridMove>().wallRight = false;
        }
        else if (col.CompareTag("up wall"))
        {
            GetComponent<GridMove>().wallUp = false;
        }
        else if (col.CompareTag("down wall"))
        {
            GetComponent<GridMove>().wallDown = false;
        }
    }

}
