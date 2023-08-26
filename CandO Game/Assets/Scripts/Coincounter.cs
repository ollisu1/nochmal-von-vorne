using UnityEngine;
using TMPro;

public class Coincounter : MonoBehaviour
{
    public TMP_Text coincounterText;

    public int CoinValue;

    private void Update()
    {
        coincounterText.text = CoinValue.ToString();
    }
}
