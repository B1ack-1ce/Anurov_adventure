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
        
        // ���� �������� ������� �� �������� � ����� � 1 �������
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float spawnStep = 2f;
        private float nextSpawnTime;

        void Update()
        {
            PlayerDetection();
        }
        /// <summary>
        /// ����� ����������� ������, ���� ����� � �������� 10 ������, 
        /// �� �� ������ ����� �� ��� � �������� ��������
        /// </summary>
        private void PlayerDetection()
        {
            float _distance = Mathf.Sqrt((_target.transform.position - transform.position).sqrMagnitude);
            if (_distance <= 10) // � ���� ���� �������, ���� ����� ������ 10�, �� ������ �� ����������
            {
                LookToPlayer();
                Shoot();
            }
            Debug.Log("��������� �� ����:" + _distance);
        }
        /// <summary>
        /// ����� �� ������� � ����� � ������� ������
        /// </summary>
        private void LookToPlayer()
        {
            Vector3 _relativePos = _target.transform.position - transform.position;
            Vector3 _newDir = Vector3.RotateTowards(transform.forward, _relativePos, _rotateSpeed * Time.deltaTime, 0);
            transform.rotation = Quaternion.LookRotation(_newDir);
        }
        /// <summary>
        /// ����� �� "��������" ���� � ������� ������
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