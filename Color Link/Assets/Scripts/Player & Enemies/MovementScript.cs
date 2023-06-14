using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
public float wlkSpeed;

public KeyCode jump;
public KeyCode left;
public KeyCode right;

public GameObject player;
public Transform trnsform;
public Rigidbody2D physics;

bool lookRight = true;

// Update is called once per frame
void Update()
{
    Walk();
}

public void Walk()
{
    if (Input.GetKey(left))
    {
        lookRight = false;
        physics.velocity -= new Vector2(wlkSpeed, 0);
        DirectionFlip();
        //when turning left, modify y axis to 180
    }
    else if (Input.GetKeyUp(left))
    {
        lookRight = false;
        physics.velocity = new Vector2(0, 0);
    }

    if (Input.GetKey(right))
    {
        lookRight = true;
        physics.velocity += new Vector2(wlkSpeed, 0);
        DirectionFlip();
        //when turning right, modify y axis back to 0
    }
    else if (Input.GetKeyUp(right))
    {
        lookRight = true;
        physics.velocity = new Vector2(0, 0);
    }
}

public void DirectionFlip()
{
        if (lookRight == true)
        {
            this.GetComponent<Transform>().localScale = new Vector2(0, 0);
        }
        else
        {
            this.GetComponent<Transform>().localScale = new Vector2(0, 180);
        }
}
}
