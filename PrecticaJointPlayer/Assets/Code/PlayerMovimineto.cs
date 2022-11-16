using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MOVEMENT
{
    JUMP,
    NULL,
    LEET,
    RIGTH
}

public class PlayerMovimineto : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed = 2f;
    public float jumpHeight = 30f;
    public bool Movement;
    public MOVEMENT MoveState;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movement = true;
            MoveState = MOVEMENT.LEET;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Movement = true; 
            MoveState = MOVEMENT.RIGTH;

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Movement = false;
            MoveState = MOVEMENT.JUMP;
        }
        else
        {
            Movement = false;
            MoveState = MOVEMENT.NULL;
        }
    }

    public void FixedUpdate()
    {
        if(MoveState == MOVEMENT.LEET)
        {
            RB.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
        else if(MoveState == MOVEMENT.RIGTH)
        {
            RB.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
        else if (MoveState == MOVEMENT.JUMP)
        {
            RB.AddForce(transform.up * jumpHeight);
        }
        else 
        {
            //RB.velocity = new Vector2(0, 0);
        }
    }
}
