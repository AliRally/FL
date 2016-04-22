using UnityEngine;
using System.Collections;

public class Movement_noLeft : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().wallLeft = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().wallLeft = false;
        }
    }
}
