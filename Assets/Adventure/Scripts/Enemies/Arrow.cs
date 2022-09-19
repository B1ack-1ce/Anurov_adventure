using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adventure.Enemies
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private float speed = 5;



        void Start()
        {
            Destroy(gameObject, 3f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.localPosition +=  transform.forward * speed * Time.deltaTime;
        }
    }
}

