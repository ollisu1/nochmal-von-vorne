using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinValue : MonoBehaviour
{
    public float Value = 0;

    Coin coin;

    public GameObject coinTest;

    [SerializeField] TextMeshProUGUI coinValue;


    private void Awake()
    {
        coin = coinTest.GetComponent<Coin>();

    }

    // Start is called before the first frame update
    void Start()
    {
        coinValue.text = "Coins : " + Value;

    }

    // Update is called once per frame
    void Update()
    {
        if(coin.sprite == false)
        {
            Value++;

        }

    }


}
