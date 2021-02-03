using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// A delay of 0 will place the background changer in question mode, changing based on the number of questions answered.
public class BackgroundChanger : MonoBehaviour
{

    private float t = Time.time;
    private float seconds = 0;
    public float delay = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private int imgnum = 0;


    void ChangeSprite()
    {
        imgnum = (int)Random.Range((float)0.0, spriteArray.Length);
        spriteRenderer.sprite = spriteArray[imgnum];
    }
    void ChangeSprite(int img)
    {
        imgnum = img;
        spriteRenderer.sprite = spriteArray[img];
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        imgnum = spriteArray.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        seconds = Time.time - t;
        if (seconds >= delay && delay != 0)
        {
            if (delay != .5)
            {
                ChangeSprite();
            }
            else
            {
                if (imgnum != spriteArray.Length -1)
                {
                    ChangeSprite(imgnum + 1);
                }
                else
                {
                    ChangeSprite(0);
                }
            }
            t = Time.time;
            seconds = 0;
        }
        if (delay == 0)
        {
            if (QuestionsCorrect.Answered >= 29)
            {
                ChangeSprite(2);
                imgnum = 2;
 
            }
            else if (QuestionsCorrect.Answered >= 19)
            {
                ChangeSprite(1);
                imgnum = 1;
            }
            else if (QuestionsCorrect.Correct >= 9)
            {
                ChangeSprite(0);
                imgnum = 0;
            }
        }
    }
}
