using UnityEngine;
using System.Collections.Generic;
public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;


    private List<Sprite> list;
    private bool disppear = false;
    private double coldTime = 0.05;
    private void Awake()
    {
        list = new List<Sprite>();
        list.Add(blueColor);
        list.Add(redColor);
        list.Add(greenColor);
        list.Add(purpleColor);
        list.Add(goldColor);
        list.Add(greyColor);
        list.Add(brownColor);
        ChooseColor();

    }
    private void Update()
    {
        if (disppear)
        {
            if (coldTime > 0)
            {
                coldTime -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    private void ChooseColor()
    {
        int ran = Mathf.RoundToInt(Random.value * 6);
        spriteRenderer.sprite = list[ran];
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        disppear = true;
    }
}
