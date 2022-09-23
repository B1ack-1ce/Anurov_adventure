using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int heroHealth; //“екущее здоровье персонажа
        private const int maxHeroHealth = 100; //ћаксимальное здоровье, ограниченное в 100 пунктов
        
        /// <summary>
        /// ћетод на полученный урон и гибель персонажа, если его здоровье опуститс€ ниже 0.
        /// </summary>
        /// <param ѕолученный урон = "damage"></param>
        public void Hurt(int damage)
        {
            heroHealth -= damage; ;
            if (heroHealth <= 0)
            {
                Die();
            }
        }
        
        /// <summary>
        /// ћетод на восполение здоровь€ персонажа.
        /// </summary>
        /// <param ѕолученное восполнение здровь€ = "health"></param>
        public void PlusHP (int health)
        {
           if (heroHealth < maxHeroHealth)
                heroHealth += health;

           if (heroHealth > maxHeroHealth)
                heroHealth = maxHeroHealth;
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}
