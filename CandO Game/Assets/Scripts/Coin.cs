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

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0);

        if (transform.position.x < -30)
        {
            transform.position = new Vector3(30f, Random.Range(-3, 3));

          //  if(spriteRenderer == enabled = false)     operator fehler == oder =  auf linker Seite der Zuordnug muss variable stehen bzw Fehler bei enabled oder false 
          //  {

           // }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            spriteRenderer.enabled = false;

        }

    }
}
