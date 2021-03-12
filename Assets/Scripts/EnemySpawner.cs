using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject EnemyPrefab;
    public GameManager gm;

    static private int EnemyCount = 5;
    public int start_count = 0;
    static private bool spawned = false;
    static private int currentCount = 5;
    static private bool inSpawn = false;
    static private bool questionTime = false;
    static private bool gameOver = false;
    static public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        currentCount = EnemyCount;
        SpawnEnemies(start_count);
        gm = FindObjectOfType<GameManager>();
        gm.DisableQandA();
        //StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCount == 0 && !questionTime)
        {
            timeRemaining = 20;
            ToggleQuestTime();
            currentCount = EnemyCount;
        }
        if (questionTime && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

    }
 /*   IEnumerator SpawnRoutine()
    {
        while (!gameOver)
        {
            if (currentCount == 0)
            {
                ToggleQuestTime();
                yield return new WaitForSeconds(3.0f);
            }
        }

    }*/
    public void SpawnEnemies()
    {
        currentCount = EnemyCount + 1;
        for (int i = 0; i < EnemyCount + 1; i++)
        {
            inSpawn = true;
            Invoke("spawnHelper", 1.5F);
        }
        EnemyCount += 1;
        inSpawn = false;
        spawned = true;
    }
    public void SpawnEnemies(int spawnCount)
    {
        for (int i = 0; i < spawnCount; i++)
        {
            inSpawn = true;
            Invoke("spawnHelper", 3.0F);
        }
        inSpawn = false;
        spawned = true;
    }
    private void spawnHelper()
    {
        Vector3 postToSpawn = new Vector3(Random.Range(-9.1f, 2.1f), 4.1f, 0);
        Instantiate(EnemyPrefab, postToSpawn, Quaternion.identity);
    }
    public void ToggleQuestTime(bool forceOff = false)
    {
        questionTime = !questionTime;
        Timer.ResetTimer();
        if (questionTime)
        {
            gm.EnableQandA();
            spawned = false;
        }
        else if (forceOff)
        {
            questionTime = false;
            gm.DisableQandA();
            SpawnEnemies();
        }
    }
    public static void EnemyKilled()
    {
        currentCount -= 1;
    }
    public static void SetEnemies(int a)
    {
        EnemyCount += a;
    }
    public static bool QT()
    {
        return questionTime;
    }

}



