using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public bool Correct = false;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator Fade()
    {
        if (Correct)
        {
            for (float ft = 1f; ft >= 0; ft -= 0.1f)
            {
                m_SpriteRenderer.color = Color.green;
                yield return new WaitForSeconds(1.2f);
            }
        }
        else
        {
            for (float ft = 1f; ft >= 0; ft -= 0.1f)
            {
                m_SpriteRenderer.color = Color.red;
                yield return new WaitForSeconds(1.2f);
            }
        }
    }
    public void GlowG()
    {
        StartCoroutine("Fade");
        Correct = true;
        StopCoroutine("Fade");
    }
    public void GlowR()
    {
        StartCoroutine("Fade");
        Correct = false;
        StopCoroutine("Fade");
    }
}
