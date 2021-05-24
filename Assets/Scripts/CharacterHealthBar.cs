using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StatsFramework
{
    public class CharacterHealthBar : MonoBehaviour
    {
        Image hPBar;
        //i want max health to be the amount i set in the array
        float maxHealth;
        public static float health;
        public Stats stats;

        private void Start()
        {
            hPBar = GetComponent<Image>();
            maxHealth = stats.CharacterStats[0].Level;
            health = maxHealth;
        }

        private void Update()
        {
            hPBar.fillAmount = health / maxHealth;
        }
    }
}