using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraj : MonoBehaviour {

    private Rigidbody2D rb;
    private float dirX, moveSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 40f;
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(dirX, rb.linearVelocity.y);
    }
}
