using UnityEngine;

[System.Serializable]
public class Question
{
    [TextArea(3,10)]
    public string question;
    public string[] answer;
    public int CorrectAnswer;

}
