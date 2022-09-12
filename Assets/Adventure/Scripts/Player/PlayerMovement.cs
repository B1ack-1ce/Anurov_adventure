using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] private float Speed = 0.3f;
        [SerializeField] private float JumpForce = 1f;
        private Rigidbody rigidbody;
        private Vector3 movementVector
        {
            get
            {
                var horizontal = Input.GetAxis("Horizontal");
                var vertical = Input.GetAxis("Vertical");

                return new Vector3(vertical, 0.0f, -horizontal);
            }
        }


        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();

        } 

        void FixedUpdate()
        {
            JumpLogic();
            MoveLogic();
        }

        private void MoveLogic()
        {
            rigidbody.AddForce(movementVector * Speed, ForceMode.Impulse);
        }

        private void JumpLogic()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            }
        }
    }
}

