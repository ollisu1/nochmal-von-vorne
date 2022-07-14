using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update


    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movment;

    public GameObject Hinderniss;
    Scoretext Score;


    // Update is called once per frame
    void Update()
    {

        movment.y = Input.GetAxisRaw("Vertical");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.tag == "Hinderniss")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
                    
        }


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);

    }
}
