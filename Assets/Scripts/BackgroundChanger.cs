using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{

    private float t = Time.time;
    private float seconds = 0;
    public float delay = 30;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    void ChangeSprite()
    {
        spriteRenderer.sprite = spriteArray[(int)Random.Range((float)0.0, spriteArray.Length)];
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
        if (seconds >= delay)
        {
            ChangeSprite();
            t = Time.time;
            seconds = 0;
        }
    }
}