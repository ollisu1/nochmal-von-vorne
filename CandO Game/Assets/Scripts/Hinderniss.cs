using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinderniss : MonoBehaviour
{
    public bool useFixedUpdate;

    public float variableToChange;

    public float changePerSecond;

    public float Speed = 7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0);

        if (transform.position.x < -30)
        {
            transform.position = new Vector3(30f, transform.position.y);

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
}
