using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Coin : MonoBehaviour
{
    Coincounter coincounter;

    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public Light2D coinlight;

    public float variableToChange;
    public float changePerSecond;
    public float Speed = 7f;

    public bool useFixedUpdate;
    public bool sprite = true;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        coincounter = GameObject.Find("CoinCounter").GetComponent<Coincounter>();
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
                boxCollider.enabled = true;
                coinlight.enabled = true;
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
            boxCollider.enabled = false;
            coinlight.enabled = false;

            coincounter.CoinValue++;
        }
    }
}