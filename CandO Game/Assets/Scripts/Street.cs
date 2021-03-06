using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public bool useFixedUpdate;

    public float variableToChange;

    public float changePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x - 35)
        {
            Destroy(this.gameObject);

        }

        if (!useFixedUpdate)
        {
            speed -= changePerSecond * Time.deltaTime;

        }
    }

    private void FixedUpdate()
    {
        if (useFixedUpdate)
        {
            speed -= changePerSecond * Time.deltaTime;

        }

    }

}
