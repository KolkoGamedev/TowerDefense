using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Enemies
{
    [CreateAssetMenu]
    public class EnemyStatistics : ScriptableObject
    {
        public float health;
        public float speed;
        public Sprite sprite;
    }

}
