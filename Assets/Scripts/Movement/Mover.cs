using System.Collections;
using System.Collections.Generic;
using Config;
using UnityEngine;

namespace Movement{
    [RequireComponent(typeof(Rigidbody))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private LayerMask groundLayer;
        private GameConfig config;
        private Rigidbody rb;
        private RaycastHit hit;
        public bool isGrounded = true;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update(){
            isGrounded = IsGrounded();
        }
        public void Move(Vector3 velocity, float speed){
            transform.position +=velocity * speed *Time.deltaTime;
        }
        public void Jump(Vector3 velocity,float force){
            if(isGrounded)
                rb.AddForce(velocity * force,ForceMode.Impulse);
        }

        private bool IsGrounded(){
            return Physics.Raycast(transform.position, Vector3.down, out hit, 1f, groundLayer);
        }
    }
}