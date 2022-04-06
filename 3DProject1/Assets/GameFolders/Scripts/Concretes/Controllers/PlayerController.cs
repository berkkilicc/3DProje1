using Project1.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Contollers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        private Rigidbody _rigidbody;
        DefaultInput _input;

        bool _isForceUp;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }

        private void Update()
        {
            
            //Input
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

        }
        private void FixedUpdate()
        {
            //fizik islemleri
            if (_isForceUp)
            {
                _rigidbody.AddForce(Vector3.up * Time.deltaTime* _force);
            }
        }
    }
}
    


