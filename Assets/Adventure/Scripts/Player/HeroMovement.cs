using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Player 
{
    public class HeroMovement : MonoBehaviour
    {
        
        private Rigidbody rigidbody;
        private Vector3 direction;
        private float vert;
        private float hor;

        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private string jump = "Jump";

        [SerializeField] private float speed = 4f;
        [SerializeField] private float rotationSpeed = 15f;

        private void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            hor = Input.GetAxis(horizontal);
            vert = Input.GetAxis(vertical);

            direction = new Vector3(vert, 0, hor);
            transform.Translate(direction);

            if (direction.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);


        }
    }
}
