using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float moveSpeed;
    
    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Vertical"))
        {
            float v = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(0, v * moveSpeed);
        }
        if (Input.GetButtonUp("Vertical")){
            rb.velocity = new Vector2(0, 0);
        }
    }
}
