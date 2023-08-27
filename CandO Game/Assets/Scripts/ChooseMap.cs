using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMap : MonoBehaviour
{
    public int Map = 0;
    public int Block = 0;

    public MapObject mapObject;

    public void Wiese()
    {
        Map = 1;
    }

    public void Ödland()
    {
        Map = 2;
    }

    public void Eis()
    {
        Map = 3;
    }

    public void Wald()
    {
        Map = 4;
    }

    public void Wüste()
    {
        Map = 5;
    }

    public void Block1()
    {
        Block = 1;
    }

    public void Block2()
    {
        Block = 2;
    }

    public void Block3()
    {
        Block = 3;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    private void Update()
    {
        mapObject.Map = Map;
        mapObject.Block = Block;
    }
}
