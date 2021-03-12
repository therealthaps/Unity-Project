using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text currentTime;
    public GameManager gm;
    public static float timeRemaining = 20;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0 && EnemySpawner.QT())
        {
            timeRemaining -= Time.deltaTime;
        }
        currentTime.text = Round(timeRemaining, 2).ToString();
        if (timeRemaining <= 0)
        {
            gm.inCorrect();
        }
    }

    public static void ResetTimer()
    {
        timeRemaining = 20;
    }
    public static float Round(float value, int digits)
    {
        float mult = Mathf.Pow(10.0f, (float)digits);
        return Mathf.Round(value * mult) / mult;
    }
}