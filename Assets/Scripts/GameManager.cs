using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    /* public Question[] questions;
     private static List<Question> unansweredQuestions;
     private Question currentQuestion;

     [SerializeField]
     private Text questionText;

     void Start()
     {
         if (unansweredQuestions == null || unansweredQuestions.Count == 0)
             unansweredQuestions = questions.ToList<Question>();

         SetCurrentQuestion();
     }

     void SetCurrentQuestion()
     {
         currentQuestion = unansweredQuestions[0];

         questionText.text = currentQuestion.question;

         unansweredQuestions.RemoveAt(0);
     }*/

    public List<Question> QnA;
    public GameObject[] options;
    public int currentQuestion = 0;
    private GameObject[] impEffs;
    public GameObject timer;
    private List<int> used;

    public Text QuestionTxt;
    public GameObject panel1;
    public GameObject panel2;
    public EnemySpawner es;
    public void Start()
    {
    }
    public void Update()
    {
        impEffs = GameObject.FindGameObjectsWithTag("Impact");
        foreach (GameObject g in impEffs)
        {
            g.SetActive(false);
        }
    }

    public void correct()
    {
        panel2.SetActive(false);
        panel1.SetActive(false);
        panel1.SetActive(true);
        if (panel1.activeSelf == true)
        {
            panel2.SetActive(false);

        }

        ScoringSystem.Correct();
        QnA.RemoveAt(currentQuestion);
        es.ToggleQuestTime(true);
    }

    public void EnableQandA()
    {
        foreach (GameObject item in options)
        {
            item.SetActive(true);
        }
        generateQuestion();
    }
    public void DisableQandA()
    {
        foreach (GameObject item in options)
        {
            item.SetActive(false);
        }
    }
    public void inCorrect()
    {
        panel2.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(true);
        if (panel2.activeSelf == true)
        {
            panel1.SetActive(false);
        }
        ScoringSystem.Incorrect();
        QnA.RemoveAt(currentQuestion);
        es.ToggleQuestTime(true);
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerOptionsScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answer[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerOptionsScript>().isCorrect = true;
            }
        }
    }

    public void generateQuestion()
    {

        QuestionTxt.text = QnA[currentQuestion].question;
        SetAnswers();
        timer.SetActive(true);
        used.Add(currentQuestion);
        if (used.Count < QnA.Count)
            currentQuestion = get_rand();

    }

    private int get_rand()
    {
        int a = Random.Range(0, 39);
        return used.IndexOf(a) != -1 ? a : get_rand();
    }

}