using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure 
{
    public class HeroMovement : MonoBehaviour
    {
        private Animator animator;
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
            animator = GetComponent<Animator>();
        }


        // Update is called once per frame
        private void Update()
        {
            hor = Input.GetAxis(horizontal);
            vert = Input.GetAxis(vertical);

            direction = new Vector3(hor, 0 , vert);
            rigidbody.velocity = Vector3.ClampMagnitude(direction, 1) * speed;

            if (direction.magnitude > Mathf.Abs(0.1f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);


        }
    }
}
