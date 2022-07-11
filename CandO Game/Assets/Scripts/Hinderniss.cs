using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinderniss : MonoBehaviour
{
    public bool useFixedUpdate;

    public float variableToChange;

    public float changePerSecond;

    public float Speed = 7f;

    public GameObject RoadPrefab;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0);

        if (transform.position.x < -30)
        {
            transform.position = new Vector3(30f, Random.Range(-3, 3));

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

    private void spawnRoad()
    {
        GameObject a = Instantiate(RoadPrefab) as GameObject;
        a.transform.position = new Vector2(-30, Random.Range(-3, 3));
    }
}
