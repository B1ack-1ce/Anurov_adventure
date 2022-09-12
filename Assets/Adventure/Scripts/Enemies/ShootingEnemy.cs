using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Adventure.Enemies
{
    public class ShootingEnemy : MonoBehaviour
    {

        [SerializeField] private GameObject arrow;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float spawnStep = 1f;
        private float nextSpawnTime;


        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                Instantiate(arrow, spawnPoint.position, Quaternion.identity);
                nextSpawnTime = Time.time + spawnStep;
                
            }

        }
    }
}