using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Adventure.Enemies
{
    public class ShootingEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        [SerializeField] private float _rotateSpeed;

        [SerializeField] private GameObject _arrow;
        
        // Поля простого таймера на стрельбу с шагом в 1 секунду
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float spawnStep = 2f;
        private float nextSpawnTime;

        void Update()
        {
            PlayerDetection();
        }
        /// <summary>
        /// Метод обнаружения игрока, если игрок в пределах 10 метрах, 
        /// то он делает фокус на нем и начинает стрелять
        /// </summary>
        private void PlayerDetection()
        {
            float _distance = Mathf.Sqrt((_target.transform.position - transform.position).sqrMagnitude);
            if (_distance <= 10) // в этом поле условие, если игрок дальше 10м, то методы не вызываются
            {
                LookToPlayer();
                Shoot();
            }
            Debug.Log("Дистанция до цели:" + _distance);
        }
        /// <summary>
        /// Метод на поворот и фокус в сторону игрока
        /// </summary>
        private void LookToPlayer()
        {
            Vector3 _relativePos = _target.transform.position - transform.position;
            Vector3 _newDir = Vector3.RotateTowards(transform.forward, _relativePos, _rotateSpeed * Time.deltaTime, 0);
            transform.rotation = Quaternion.LookRotation(_newDir);
        }
        /// <summary>
        /// Метод на "открытие" огня в сторону игрока
        /// </summary>
        private void Shoot()
        {
            if (Time.time > nextSpawnTime)
            {
                Instantiate(_arrow, spawnPoint.transform.position, transform.rotation);
                nextSpawnTime = Time.time + spawnStep;
            }
        }

    }
}