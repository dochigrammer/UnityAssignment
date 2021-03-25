using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float CurrentTime = 0.0f;
    private float SpawnIntervalTime = 0.0f;

    public float SpawnIntervalMinTime = 1.0f;
    public float SpawnIntervalMaxTime = 5.0f;
    public GameObject EnemyGameObject = null;

    // Start is called before the first frame update
    void Start()
    {
        SpawnIntervalTime = Random.Range(SpawnIntervalMinTime, SpawnIntervalMaxTime);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;

        if( CurrentTime >= SpawnIntervalTime)
        {
            CurrentTime = 0.0f;

            SpawnEnemy();
        }
    }


    protected void SpawnEnemy()
    {
        GameObject enemy = Instantiate(EnemyGameObject);
        
        if( enemy == null)
        {
            Debug.LogWarning("SpawnEnemy : Instantiate Fail");
        }

        if( enemy != null)
        {
            enemy.transform.position = transform.position;
        }
    }


}
