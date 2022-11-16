using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float grave = 10;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = grave;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb2d.gravityScale == grave)
            {
                rb2d.gravityScale = -grave;
            }
            else if (rb2d.gravityScale == -grave)
            {
                rb2d.gravityScale = grave;
            }
        }
    }
}
