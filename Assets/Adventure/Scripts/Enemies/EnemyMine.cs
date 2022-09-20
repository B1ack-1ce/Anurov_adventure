using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class EnemyMine : MonoBehaviour
    {
        [SerializeField] private int damage;

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

