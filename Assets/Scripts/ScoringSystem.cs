using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// code taken from youtuber tutorial 
// https://www.youtube.com/watch?v=QbqnDbexrCw&vl=en

/*remainder of code and references to this code are in the player object
 * for each correct answer up to 5: + 1000 pts per answer
 * for each correct answer up to 10: + 2000 pts per answer
 * for each correct answer up to 20: + 4000 pts per answer
 * for each correct answer greater than 20: + 8000 pts per answer
 * for each incorrect answer streak reset to 0 and 1000 pts lost
 * */
public class ScoringSystem : MonoBehaviour
{

    public static int Points = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Points.ToString();
    }
}
