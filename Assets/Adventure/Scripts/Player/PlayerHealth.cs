using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int heroHealth; //������� �������� ���������
        private const int maxHeroHealth = 100; //������������ ��������, ������������ � 100 �������
        
        /// <summary>
        /// ����� �� ���������� ���� � ������ ���������, ���� ��� �������� ��������� ���� 0.
        /// </summary>
        /// <param ���������� ���� = "damage"></param>
        public void Hurt(int damage)
        {
            heroHealth -= damage; ;
            if (heroHealth <= 0)
            {
                Die();
            }
        }
        
        /// <summary>
        /// ����� �� ���������� �������� ���������.
        /// </summary>
        /// <param ���������� ����������� ������� = "health"></param>
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
