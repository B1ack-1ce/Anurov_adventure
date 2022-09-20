using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int health;

        public void Hurt(int damage)
        {
            health -= damage; ;
            if (health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}
