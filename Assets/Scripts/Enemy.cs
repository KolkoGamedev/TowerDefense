using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Enemies;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStatistics enemyStatistics = null;
    private float _health = 0;
    
    private void Awake()
    {
        _health = enemyStatistics.health;
        GetComponent<SpriteRenderer>().sprite = enemyStatistics.sprite;
    }
}
