using UnityEngine;
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