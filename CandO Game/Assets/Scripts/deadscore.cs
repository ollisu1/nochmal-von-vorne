using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class deadscore : MonoBehaviour
{
    Scoretext Highscore;
    [SerializeField] TextMeshProUGUI m_Object;
    public Scoretext dasScript;

    // Start is called before the first frame update
    void Start()
    {
     //   dasScript = Component<Scoretext.Highscore>();
       // Debug.Log(Scoretext.Update());
        m_Object.text = "Score : " + dasScript;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
