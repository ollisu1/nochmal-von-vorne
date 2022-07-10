using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update


    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movment;



    // Update is called once per frame
    void Update()
    {

        movment.y = Input.GetAxisRaw("Vertical");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);

    }
}
