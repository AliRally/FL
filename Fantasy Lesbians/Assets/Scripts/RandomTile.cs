using UnityEngine;
using System.Collections;

public class RandomTile : MonoBehaviour {

    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;

    private SpriteRenderer render;

	// Use this for initialization
	void Start () 
    {
        render = GetComponent<SpriteRenderer>();
        if (render.sprite == null)
            render.sprite = s1;

        var spriteCount = Random.Range(1, 6);

        if (spriteCount == 1)
            render.sprite = s1;

        if (spriteCount == 2)
            render.sprite = s2;

        if (spriteCount == 3)
            render.sprite = s3;

        if (spriteCount == 4)
            render.sprite = s4;

        if (spriteCount == 5)
            render.sprite = s5;

        if (spriteCount == 6)
            render.sprite = s6;
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
