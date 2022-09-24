using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab; // ������ ������� ��� ������
        [SerializeField] private float spawnStep = 1f; // ��� ������
        private float nextSpawnTime; // ������� ������


        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                var enemy = Instantiate(enemyPrefab, transform);
                nextSpawnTime = Time.time + spawnStep; // ��������� ������� ����� ������ 1 �������
                Destroy(enemy.gameObject, 1.5f); // ����� ��������� ������ ������������ ����� 1.5 �������
            }
            
        }
    }
}
