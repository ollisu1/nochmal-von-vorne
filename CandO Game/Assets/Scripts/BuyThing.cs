using UnityEngine;

public class BuyThing : MonoBehaviour
{
    public GameObject buybtn;
    public GameObject Lock;

    public int price;

    public void �dland()
    {
        if(price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("�dland") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("�dland", 1);
            Lock.SetActive(false);
            buybtn.SetActive(false);
        }
    }

    public void Eis()
    {
        if (price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("Eis") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("Eis", 1);
            Lock.SetActive(false);
            buybtn.SetActive(false);
        }
    }

    public void Wald()
    {
        if (price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("Wald") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("Wald", 1);
            Lock.SetActive(false);
            buybtn.SetActive(false);
        }
    }

    public void W�ste()
    {
        if (price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("W�ste") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("W�ste", 1);
            Lock.SetActive(false);
            buybtn.SetActive(false);
        }
    }
}
