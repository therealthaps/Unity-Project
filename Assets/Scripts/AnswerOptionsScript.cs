using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerOptionsScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameManager quizManager;
    public GameObject panel1;


    public void Answer()
    {
        if (isCorrect)
        {
            quizManager.correct();
            panel1.SetActive(true);

        }
        else
        {
            quizManager.inCorrect();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            Answer();
        }
    }


}
