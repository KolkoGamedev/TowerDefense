using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Turrets
{ 
    [CreateAssetMenu] 
    public class BaseTurret : ScriptableObject
    {
        public float damage = 5f;
        public float rateOfFire = 60f;
        public Element turretElement = Element.Wind;
    }
}

public enum Element
{
    Fire,
    Cold,
    Water,
    Wind,
    Earth,
    Neutral
}
