using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TimeManager : MonoBehaviour
{
    public Light2D light1;
    public Light2D light2;
    public Light2D light3;
    public Light2D light4;
    public Light2D Sun;

    public float TimeChange = 10f;

    public bool Night;

    private void Start()
    {
        NightOff();
        StartCoroutine(NightBegin());
    }

    private void Update()
    {
        Sun.intensity -= 0.001f / 40;

        /*if (Input.GetKeyDown(KeyCode.T) && Night)
        {
            Night = false;
            NightOff();
        }
        else if (Input.GetKeyDown(KeyCode.T) && !Night)
        {
            Night = true;
            NightOn();
        }*/
    }

    public void NightOn()
    {
        Sun.intensity = 0.15f;
        light1.enabled = true;
        light2.enabled = true;
        light3.enabled = true;
        light4.enabled = true;
    }

    public void NightOff()
    {
        Sun.intensity = 1;

        light1.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
        light4.enabled = false;
    }

    IEnumerator NightBegin()
    {
        //Sun.intensity -= TimeChange * Time.deltaTime;

        yield return new WaitForSeconds(60);
        light1.enabled = true;
        light2.enabled = true;
        light3.enabled = true;
        light4.enabled = true;
    }
}