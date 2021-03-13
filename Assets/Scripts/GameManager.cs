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
    public int currentQuestion;
    private GameObject[] impEffs;
    public EnemySpawner es;
    public GameObject LevelComplete;
    public Text QuestionTxt;
    public GameObject panel1;
    public GameObject panel2;
    public Glow[] glows;
    public void Start()
    {}
    public void Update()
    {
        impEffs = GameObject.FindGameObjectsWithTag("Impact");
        foreach (GameObject g in impEffs)
        {
            g.SetActive(false);
        }
        if (QnA.Count == 0)
        {
            LevelComplete.SetActive(true);
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
        foreach (Glow g in glows) {
            g.GlowG();
        }
        es.ToggleQuestTime(true);
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
        foreach(Glow g in glows) {
            g.GlowG();
        }
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

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestion].question;
        SetAnswers();



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
}