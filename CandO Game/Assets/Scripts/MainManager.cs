using UnityEngine;

public class MainManager : MonoBehaviour
{
    public MapObject mapObject;
    public SpriteRenderer mapRenderer1;
    public SpriteRenderer mapRenderer2;
    public SpriteRenderer mapRenderer3;
    public SpriteRenderer mapRenderer4;
    public SpriteRenderer mapRenderer5;
    public SpriteRenderer blockRenderer1;
    public SpriteRenderer blockRenderer2;
    public SpriteRenderer blockRenderer3;
    public Sprite Wiese;
    public Sprite �dland;
    public Sprite Eis;
    public Sprite Wald;
    public Sprite W�ste;
    public Sprite Block1;
    public Sprite Block2;
    public Sprite Block3;


    private void Start()
    {
        switch (mapObject.Map)
        {
            case 1:
                mapRenderer1.sprite = Wiese;
                mapRenderer2.sprite = Wiese;
                mapRenderer3.sprite = Wiese;
                mapRenderer4.sprite = Wiese;
                mapRenderer5.sprite = Wiese;
                break;
            case 2:
                mapRenderer1.sprite = �dland;
                mapRenderer2.sprite = �dland;
                mapRenderer3.sprite = �dland;
                mapRenderer4.sprite = �dland;
                mapRenderer5.sprite = �dland;
                break;
            case 3:
                mapRenderer1.sprite = Eis;
                mapRenderer2.sprite = Eis;
                mapRenderer3.sprite = Eis;
                mapRenderer4.sprite = Eis;
                mapRenderer5.sprite = Eis;
                break;
            case 4:
                mapRenderer1.sprite = Wald;
                mapRenderer2.sprite = Wald;
                mapRenderer3.sprite = Wald;
                mapRenderer4.sprite = Wald;
                mapRenderer5.sprite = Wald;
                break;
            case 5:
                mapRenderer1.sprite = W�ste;
                mapRenderer2.sprite = W�ste;
                mapRenderer3.sprite = W�ste;
                mapRenderer4.sprite = W�ste;
                mapRenderer5.sprite = W�ste;
                break;
        }

        switch (mapObject.Block)
        {
            case 1:
                blockRenderer1.sprite = Block1;
                blockRenderer2.sprite = Block1;
                blockRenderer3.sprite = Block1;
                break;
            case 2:
                blockRenderer1.sprite = Block2;
                blockRenderer2.sprite = Block2;
                blockRenderer3.sprite = Block2;
                break;
            case 3:
                blockRenderer1.sprite = Block3;
                blockRenderer2.sprite = Block3;
                blockRenderer3.sprite = Block3;
                break;
        }
    }
}
