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

    void ChangeSprite()
    {
        spriteRenderer.sprite = spriteArray[(int)Random.Range((float)0.0, spriteArray.Length)];
    }
    void ChangeSprite(int img)
    {
        spriteRenderer.sprite = spriteArray[img];
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds = Time.time - t;
        if (seconds >= delay && delay != 0)
        {
            ChangeSprite();
            t = Time.time;
            seconds = 0;
        }
        if (delay == 0)
        {
            if (QuestionsCorrect.Answered >= 29)
            {
                ChangeSprite(0);
            }
            else if (QuestionsCorrect.Answered >= 19)
            {
                ChangeSprite(1);
            }
            else if (QuestionsCorrect.Correct >= 9)
            {
                ChangeSprite(2);
            }
        }
    }
}
