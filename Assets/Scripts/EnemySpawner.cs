using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Enemies;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Wave> waves;
    [SerializeField] private GameObject enemyPrefab = null;
    [SerializeField] private int waveIndex = 0;
    private void Awake()
    {
        PrewarmEnemies();
    }

    private void PrewarmEnemies()
    {
        for (int i = 0; i < GetEnemyPrewarmCount()*2; i++)
        {
            GameObject spawnedEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            spawnedEnemy.GetComponent<Enemy>().Setup(waves[waveIndex].listOfEnemies[0]);
        }
    }

    private int GetEnemyPrewarmCount()
    {
        int max = 0;
        for (int i = 0; i < waves.Count; i++)
        {
            if (waves[i].amountOfEnemies > max)
                max = waves[i].amountOfEnemies;
        }

        return max;
    }


}

[Serializable] public class Wave
{
    public int amountOfEnemies = 0;
    //public int currentAmountOfEnemies = 0;
    public List<EnemyStatistics> listOfEnemies = null;
}
