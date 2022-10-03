using Adventure.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSphere : MonoBehaviour
{
    [SerializeField] private int _health; // ¬осполн€емое здоровье персонажа

    /// <summary>
    /// ћетод аналогичный методу мины, только на восполнение здоровь€
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerHealth>();
            player.PlusHP(_health);
            Debug.Log("—фера восполнила: " + _health);
            Destroy(gameObject);
        }
    }
}
