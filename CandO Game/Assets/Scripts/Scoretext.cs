using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoretext : MonoBehaviour
{

    private float currentscore = 0;
    public float Highscore;

    BGScroller Wert;

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {

        m_Object.text = "Score : " + currentscore;

    }

    // Update is called once per frame
     void Update()
    {
        m_Object.text = "Score : " + currentscore + Wert;

      //  Wert = GameObject.Find("BGScrollerspeed").GetComponent<BGScroller>();
        // Wert.Speed();
        //  currentscore = Debug.Log (Wert.Speed);                    //PlayerPrefs.GetInt("TOTALSCORE");
        //  PlayerPrefs.Setfloat("SHOWSTARTSCORE", currentscore);
        // Debug.Log (Wert.speed);

        currentscore++;
        Highscore = currentscore;
        return;
    }

   
  
}
