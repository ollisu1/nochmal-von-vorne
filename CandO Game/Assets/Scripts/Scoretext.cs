using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoretext : MonoBehaviour
{

    private int currentscore = 0;
    public static int Highscore;

    BGScroller Wert;

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {

        m_Object.text = "Score : " + currentscore;

    }

    // Update is called once per frame
    public void Update()
    {
        m_Object.text = "Score : " + currentscore + Wert;

        currentscore++;
        Highscore = currentscore;
        
    }


    public static int Endhigh()
    {
        return Highscore;
    }
    
}
