using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsCorrect : MonoBehaviour
{
    public static int Correct = 0;
    public static int Streak = 0;
    public static int Answered = 0;
    public static int Next = 5; //the next streak multiplier level
    Text count;
    // Start is called before the first frame update
    void Start()
    {
        count = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        count.text = Answered.ToString();
        if (Streak == Next)
        {
            Next = Next * 2;
        }
    }
}
