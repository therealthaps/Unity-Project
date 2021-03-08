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

    // Start is called before the first frame update
    void Start()
    {
        currentCount = EnemyCount;
        SpawnEnemies(start_count);
        gm = FindObjectOfType<GameManager>();
        gm.DisableQandA();
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine()
    {
        while (!gameOver)
        {
            if (currentCount == 0)
            {
                ToggleQuestTime();
                return 0;
            }
        }

    }
    public void SpawnEnemies()
    {
        for (int i = 0; i < (EnemyCount + 1); i++)
        {
            inSpawn = true;
            Invoke("spawnHelper", 3.0F);
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
    public static bool GetQuestTime()
    {
        return questionTime;
    }
    public void ToggleQuestTime()
    {
        questionTime = !questionTime;
        if (questionTime)
        {
            gm.EnableQandA();
            spawned = false;
        }
        else
        {
            gm.DisableQandA();
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

}
    


