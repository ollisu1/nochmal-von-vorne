using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployRoad : MonoBehaviour
{
    public GameObject RoadPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Road());
    }

    private void spawnRoad()
    {
        GameObject a = Instantiate(RoadPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator Road()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnRoad();

        }

    }
}
