using UnityEngine;
using TMPro;

public class GetCoins : MonoBehaviour
{
    public TMP_Text coinValue;
    private int coinAmount;

    private void Start()
    {
        coinAmount = PlayerPrefs.GetInt("CoinValue");
        coinValue.text = "Coins: " + coinAmount.ToString();
    }
}
