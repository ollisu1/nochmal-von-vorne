using UnityEngine;

public class BuyThing : MonoBehaviour
{
    public GameObject buybtn;
    public GameObject Lock;

    public int price;

    public void Ödland()
    {
        if(price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("Ödland") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("Ödland", 1);
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

    public void Wüste()
    {
        if (price <= PlayerPrefs.GetInt("CoinValue") && PlayerPrefs.GetInt("Wüste") == 0)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") - price);
            PlayerPrefs.SetInt("Wüste", 1);
            Lock.SetActive(false);
            buybtn.SetActive(false);
        }
    }
}
