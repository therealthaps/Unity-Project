using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerOptionsScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong");
        }
    }

}
