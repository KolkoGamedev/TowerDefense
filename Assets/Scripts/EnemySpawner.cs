using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Enemies;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Wave> waves;
    [SerializeField] private GameObject enemyPrefab = null;
    private void Awake()
    {
        PrewarmEnemies();
    }

    private void PrewarmEnemies()
    {
        /*
        for (int i = 0; i < ; i++)
        {
            
        }
        */
    }

}

[Serializable] public class Wave
{
    public int amountOfEnemies = 0;
    public int currentAmountOfEnemies = 0;
    public List<EnemyStatistics> listOfEnemies = null;
}
