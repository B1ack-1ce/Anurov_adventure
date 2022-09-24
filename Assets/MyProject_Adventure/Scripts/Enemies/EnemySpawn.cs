using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab; // префаб объекта для спавна
        [SerializeField] private float spawnStep = 1f; // шаг спавна
        private float nextSpawnTime; // простой таймер


        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                var enemy = Instantiate(enemyPrefab, transform);
                nextSpawnTime = Time.time + spawnStep; // появление объекта через каждую 1 секунду
                Destroy(enemy.gameObject, 1.5f); // После появления объект уничтожается через 1.5 секунды
            }
            
        }
    }
}
