using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Adventure.Player 
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private float _rotationSpeed = 2f;

        private Vector3 _direction;
        private Vector3 _rotationDir;
        private string hor = "Horizontal";
        private string ver = "Vertical";
        private const string MouseX = "Mouse X";
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
            _direction.z = Input.GetAxis(hor);
            _direction.x = Input.GetAxis(ver);

          
            var move = _direction * _speed * Time.deltaTime;
            transform.Translate(move);
        }

        private void Rotate()
        {
            transform.Rotate(_rotationDir);

            _rotationDir.y = Input.GetAxis(MouseX) * _rotationSpeed * Time.deltaTime;
        }

    }
}
