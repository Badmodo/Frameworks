using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StatsFramework;
using UnityEngine.UI;

namespace StatsFramework
{
    public class HPBar : MonoBehaviour
    {

        Image healthBar;
        [HideInInspector] public int health;
        public int MaxHealth = 1;

        public Stats StatsInfo;

        private void Start()
        {
            //MaxHealth = StatsInfo.CharacterStats.GetValue(index0);
            healthBar = GetComponent<Image>();
            health = MaxHealth;
        }

        private void Update()
        {
            healthBar.fillAmount = health / MaxHealth;
        }

        public void TakeDamage(int amount)
        {
            health -= amount;

            if (health <= 0f)
            {
                Die();
            }
        }

        void Die()
        {
            Destroy(gameObject);
        }

        //[SerializeField] 
        //GameObject healthImage;
        //Stats StatsInfo;
        //public float health;
        //public float currentHp;

        ////private void Start()
        ////{
        ////    //testing if the HP bar works
        ////    healthImage.transform.localScale = new Vector3(0.5f, 1f);
        ////}
        // private void Awake()
        //{
        //    health = StatsInfo.CharacterStats.GetValue(index0);
        //    currentHp = health;
        //}

        ////Set Hp
        //public void SetHp(float hpNormalised)
        //{
        //    healthImage.transform.localScale = new Vector3(hpNormalised, 1f);
        //}

        ////animate the Hp falling over time
        //public IEnumerator SetHPSmooth(float newHp)
        //{
        //    currentHp = healthImage.transform.localScale.x;
        //    float changeAmount = currentHp - newHp;

        //    while (currentHp - newHp > Mathf.Epsilon)
        //    {
        //        currentHp -= changeAmount * Time.deltaTime;
        //        healthImage.transform.localScale = new Vector3(currentHp, 1f);
        //        yield return null;
        //    }

        //    healthImage.transform.localScale = new Vector3(newHp, 1f);
        //}
    }
}