using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

    private bool credit = false;
    public GameObject camera;

	// Use this for initialization
	void Start () 
    {
       
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {

        if (credit == true)
        {
            camera.transform.position = new Vector3(0, -144, -10);

            if (GUI.Button(new Rect(0, 250, 175, 75), "Back"))
            {
                Debug.Log("no credit");
                credit = false;
            }
        }
        else
        {
            camera.transform.position = new Vector3(0, 0, -10);

            if (GUI.Button(new Rect(0, 175, 175, 75), "Start Game"))
            {
                Debug.Log("start game");
                Application.LoadLevel("Scene1");
            }

            if (GUI.Button(new Rect(0, 250, 175, 75), "Show Credit"))
            {
                Debug.Log("credit");
                credit = true;
            }
        }

    }
}
