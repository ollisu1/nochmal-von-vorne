using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool useFixedUpdate;

    public float variableToChange;

    public float changePerSecond;

    public float Speed = 7f;

    public SpriteRenderer spriteRenderer;

    public bool sprite = true;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0);

        if (transform.position.x < -30)
        {
            transform.position = new Vector3(30f, Random.Range(-3, 3));

            if(spriteRenderer.enabled == false)
            {
                spriteRenderer.enabled = true;
            }
        }

        if (!useFixedUpdate)
        {
            Speed -= changePerSecond * Time.deltaTime;

        }

    }

    private void FixedUpdate()
    {
        if (useFixedUpdate)
        {
            Speed -= changePerSecond * Time.deltaTime;

        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            spriteRenderer.enabled = false;

            sprite = false;

        }

    }
}