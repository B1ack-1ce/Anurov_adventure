using Adventure.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSphere : MonoBehaviour
{
    [SerializeField] private int _health; // ������������ �������� ���������

    /// <summary>
    /// ����� ����������� ������ ����, ������ �� ����������� ��������
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerHealth>();
            player.PlusHP(_health);
            Debug.Log("����� ����������: " + _health);
            Destroy(gameObject);
        }
    }
}
