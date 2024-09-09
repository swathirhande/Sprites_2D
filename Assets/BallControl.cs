using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3f; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");

        
        rb.velocity = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y); 
    }

  
}






