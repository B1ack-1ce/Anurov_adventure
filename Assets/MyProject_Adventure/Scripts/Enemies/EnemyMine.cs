using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class EnemyMine : MonoBehaviour
    {
        [SerializeField] private int damage; // наносимый урон персонажу

        /// <summary>
        /// Метод на урон от вражеской мины
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                var player = other.GetComponent<PlayerHealth>();
                player.Hurt(damage);
                Debug.Log("Мина нанесла: " + damage);
                Destroy(gameObject);
            }
        }

    }
}

