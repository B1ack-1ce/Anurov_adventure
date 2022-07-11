using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure 
{
    public class HeroMovement : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField] private float speed = 3f;
        
        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private string jump = "Jump";




        // Update is called once per frame
        private void Update()
        {
            direction.x = Input.GetAxis(horizontal);
            direction.z = Input.GetAxis(vertical);
            direction.y = Input.GetAxis(jump);

            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
