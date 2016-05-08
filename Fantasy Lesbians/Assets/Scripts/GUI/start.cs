using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

    private bool credit = false;

    GUIStyle style = new GUIStyle();

    public Texture boxtexture;

	// Use this for initialization
	void Start () 
    {
        style.alignment = TextAnchor.MiddleCenter;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {

        if (GUI.Button(new Rect(0, 0, 175, 75), "Start Game"))
        {
            Debug.Log("start game");
            Application.LoadLevel("Scene1");
        }

        if (GUI.Button(new Rect(0, 175, 175, 75), "Show Credit"))
        {
            Debug.Log("credit");
            credit = true;
        }

        if (credit == true)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "This is a box", style);
            if (GUI.Button(new Rect(175, 175, 175, 75), "Back"))
            {
                Debug.Log("no credit");
                credit = false;
            }
        }

    }
}
