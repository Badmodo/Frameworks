using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatsFramework
{
    public class EnemyDamage : MonoBehaviour
    {
        public Stats stats;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            CharacterHealthBar.health -= stats.CharacterStats[0].Level;
            //stats.CharacterStats[1].Level;
        }
    }
}