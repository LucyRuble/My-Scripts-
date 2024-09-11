using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    public float speed;
    public float vorp;
    public Animator yuh;
    public bool moving = false;
    private SpriteRenderer SpriteRenderer;

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKeyDown(left))
        {
            SpriteRenderer.flipX = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            yuh.SetBool("isMoving", true);
        }
        if (Input.GetKeyDown(right))
        {
            SpriteRenderer.flipX = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
            yuh.SetBool("isMoving", true);
        }
        if (Input.GetKeyDown(down))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(vorp, GetComponent<Rigidbody2D>().velocity.y);
            yuh.SetBool("isMoving", false);

        }
    }
}
