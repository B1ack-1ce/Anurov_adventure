using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player 
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 3f;
        [SerializeField] private float rotationSpeed = 15f;

        private Rigidbody rigidbody;
        private Vector3 direction;

        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private string jump = "Jump";

        private void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            direction.z = Input.GetAxis(horizontal);
            direction.x = Input.GetAxis(vertical);
        }

        private void FixedUpdate()
        {
            var move = direction * speed * Time.deltaTime;
            transform.Translate(move);

            //if (direction.magnitude > Mathf.Abs(0.05f))
               // transform.rotation = Quaternion.Lerp();


        }
    }
}
