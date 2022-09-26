using Adventure.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class Arrow : MonoBehaviour
    {
        private float _speed = 100f;
        private int _damage = 10;
        private float timeDestroy = 3f;
        private Rigidbody _rb;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.AddForce(Vector3.left * _speed * Time.deltaTime, ForceMode.Impulse); //�������� ������ ���� �������� 
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

