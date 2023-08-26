using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TimeManager : MonoBehaviour
{
    public Light2D light1;
    public Light2D light2;
    public Light2D Sun;

    public bool Night;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Night)
        {
            Night = false;
            NightOff();
        }
        else if (Input.GetKeyDown(KeyCode.T) && !Night)
        {
            Night = true;
            NightOn();
        }
    }

    public void NightOn()
    {
        Sun.intensity = 0.2f;
        light1.enabled = true;
        light2.enabled = true;
    }

    public void NightOff()
    {
        Sun.intensity = 1;

        light1.enabled = false;
        light2.enabled = false;
        
    }
}
