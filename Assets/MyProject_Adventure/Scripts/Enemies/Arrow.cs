using Adventure.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField ]private float _speed = 100f;
        private int _damage = 10;
        private float timeDestroy = 3f;
        private Rigidbody _rb;
        private Vector3 _vectorShoot;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _vectorShoot = FindObjectOfType <ShootingEnemy> ().spawnPoint.transform.forward; //�������� ��������� ������� ArrowSpawn �� ������ "ShootingEnemy" 
        }

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.AddForce(_vectorShoot * _speed * Time.deltaTime, ForceMode.Impulse); //�������� ������ ���� �������� 
            Invoke("DestroyBullet", timeDestroy); //����������� ������ ����� ���. �����, ���� �� ������ � ������
        }
        /// <summary>
        /// ����� �� ��������� �����, ���������� ����� �� ����, ������ ����� ��������
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                var player = collision.gameObject.GetComponent<PlayerHealth>();
                player.Hurt(_damage);
                Debug.Log("������ �������: " + _damage);
                Destroy(gameObject);
            }
        }

        void DestroyBullet()
        {
            Destroy(gameObject);
        }

    }
}

