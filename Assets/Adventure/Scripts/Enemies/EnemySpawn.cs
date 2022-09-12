using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private float spawnStep = 1f;
        private float nextSpawnTime;


        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                var enemy = Instantiate(enemyPrefab, transform);
                nextSpawnTime = Time.time + spawnStep;
                Destroy(enemy.gameObject, 1f);
            }
            
        }
    }
}
