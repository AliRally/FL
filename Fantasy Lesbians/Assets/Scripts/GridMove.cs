﻿using UnityEngine;
using System.Collections;

public class GridMove : MonoBehaviour 
{

    private float moveSpeed = 128f;
    private float gridSize = 64f;
    private enum Orientation { Horizontal, Vertical };

    private Orientation gridOrientation = Orientation.Horizontal;
    private bool allowDiagonals = false;
    private bool correctDiagonalSpeed = true;
    private Vector2 input;
    public bool isMoving = false;
    private Vector3 startPosition, endPosition;
    private float t;
    private float factor;

    public bool wallLeft = false;
    public bool wallRight = false;
    public bool wallUp = false;
    public bool wallDown = false;
	
	// Update is called once per frame
	void Update ()
    {

            if (!isMoving)
            {
                input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                if (!allowDiagonals)
                {
                    if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
                    {
                        input.y = 0;
                    }
                    else
                    {
                        input.x = 0;
                    }
                }

                if (input != Vector2.zero && Input.GetKey(KeyCode.A) && wallLeft == false)
                {
                    StartCoroutine(move(transform));
                }
                else if (input != Vector2.zero && Input.GetKey(KeyCode.D) && wallRight == false)
                {
                    StartCoroutine(move(transform));
                }
                else if (input != Vector2.zero && Input.GetKey(KeyCode.W) && wallUp == false)
                {
                    StartCoroutine(move(transform));
                }
                else if (input != Vector2.zero && Input.GetKey(KeyCode.S) && wallDown == false)
                {
                    StartCoroutine(move(transform));
                }
            }
        
    }

    public IEnumerator move(Transform transform)
    {
        isMoving = true;
        startPosition = transform.position;
            t = 0;

            if (gridOrientation == Orientation.Horizontal)
            {
                endPosition = new Vector3(startPosition.x + System.Math.Sign(input.x) * gridSize, startPosition.y + System.Math.Sign(input.y) * gridSize, startPosition.z);
            }
            else
            {
                endPosition = new Vector3(startPosition.x + System.Math.Sign(input.x) * gridSize, startPosition.y + System.Math.Sign(input.y) * gridSize, startPosition.z);
            }

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
                t += Time.deltaTime * (moveSpeed / gridSize) * factor;
                transform.position = Vector3.Lerp(startPosition, endPosition, t);
                yield return null;
            }

            isMoving = false;
            yield return 0;
        }
    
}
