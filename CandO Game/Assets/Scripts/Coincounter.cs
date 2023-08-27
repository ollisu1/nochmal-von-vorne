using UnityEngine;
using TMPro;

public class Coincounter : MonoBehaviour
{
    public TMP_Text coincounterText;

    public int CoinValue;

    private void Update()
    {
        CoinValue = PlayerPrefs.GetInt("CoinValue");
        coincounterText.text = "Coins: " + CoinValue.ToString();
    }
}
