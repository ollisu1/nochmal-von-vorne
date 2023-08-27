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
    public Sprite Ödland;
    public Sprite Eis;
    public Sprite Wald;
    public Sprite Wüste;
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
                mapRenderer1.sprite = Ödland;
                mapRenderer2.sprite = Ödland;
                mapRenderer3.sprite = Ödland;
                mapRenderer4.sprite = Ödland;
                mapRenderer5.sprite = Ödland;
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
                mapRenderer1.sprite = Wüste;
                mapRenderer2.sprite = Wüste;
                mapRenderer3.sprite = Wüste;
                mapRenderer4.sprite = Wüste;
                mapRenderer5.sprite = Wüste;
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
