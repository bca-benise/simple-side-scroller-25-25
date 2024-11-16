using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundChecker;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public bool onGround;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        Physics2D.queriesHitTriggers = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundChecker.position, groundCheckRadius, groundLayer);
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 8);
        }
    }
}
