using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float changeSpeed = 0.5f;
    public Rigidbody2D rb;

    Vector2 movment;

    public GameObject Hinderniss;

    void Update()
    {
        movment.y = Input.GetAxisRaw("Vertical");
        moveSpeed += changeSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hinderniss")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
    }
}