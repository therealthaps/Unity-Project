using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreakMultiplier : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (QuestionsCorrect.Streak >= 5 && QuestionsCorrect.Streak < 10)
        {
            txt.text = "x2";
        }
        if (QuestionsCorrect.Streak >= 10 && QuestionsCorrect.Streak < 20)
        {
            txt.text = "x4";
        }
        if (QuestionsCorrect.Streak >= 20)
        {
            txt.text = "x8";
        }
    }
}
