using UnityEngine;

public class Ödland : MonoBehaviour
{
    public GameObject Lock1;
    public GameObject btn1;
    public GameObject Lock2;
    public GameObject btn2;
    public GameObject Lock3;
    public GameObject btn3;
    public GameObject Lock4;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject Lock5;
    public GameObject btn6;
    public GameObject Lock6;

    private void Start()
    {
        if(PlayerPrefs.GetInt("Ödland") == 1)
        {
            Lock1.SetActive(false);
            btn1.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Eis") == 1)
        {
            Lock2.SetActive(false);
            btn2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Wald") == 1)
        {
            Lock3.SetActive(false);
            btn3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Wüste") == 1)
        {
            Lock4.SetActive(false);
            btn4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Block") == 1)
        {
            Lock5.SetActive(false);
            btn5.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Block2") == 1)
        {
            Lock6.SetActive(false);
            btn6.SetActive(false);
        }
    }
}