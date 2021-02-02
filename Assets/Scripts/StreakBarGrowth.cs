using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreakBarGrowth : MonoBehaviour
{
    static private float fill = 0;
    public static Image BarImage;
    static private int next = 5;
    static private int last = 0;
    static private int streak = 0;
    private void Awake()
    {
        BarImage = transform.Find("streak bar").GetComponent<Image>();
    }
    public static void SetStreak()
    {
        next = QuestionsCorrect.Next;
        streak = QuestionsCorrect.Streak;
        if (streak == next)
        {
            BarImage.fillAmount = 0;
            last = next;
        }
        else
        {
            BarImage.fillAmount = (float)(streak - last) / (next - last);
        }
   
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
