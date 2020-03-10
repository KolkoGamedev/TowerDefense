using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Enemies;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health = 0;
    public void Setup(EnemyStatistics enemyStatistics)
    {
        _health = enemyStatistics.health;
        GetComponent<SpriteRenderer>().sprite = enemyStatistics.sprite;
    }
}
