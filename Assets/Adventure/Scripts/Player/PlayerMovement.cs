using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Adventure.Player 
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 3f;
        [SerializeField] private float rotationSpeed = 2f;

        private Vector3 direction;
        private string hor = "Horizontal";
        private string ver = "Vertical";
        //private string jump = "Jump";

        private void Start()
        {
           // rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Movement();
            Rotate();
        }
        
        private void Movement()
        {
            direction.z = Input.GetAxis(hor);
            direction.x = Input.GetAxis(ver);

            var move = direction * speed * Time.deltaTime;
            transform.Translate(move);
        }

        private void Rotate()
        {
            
        }

    }
}
