using Project1.Inputs;
using System.Collections;
using System.Collections.Generic;
using Project1.Contollers;
using Project1.Movements;
using UnityEngine;

namespace Project1.Contollers
{
    public class PlayerController : MonoBehaviour
    {
        
        DefaultInput _input;
        Mover _mover;

        bool _isForceUp;

        private void Awake()
        {            
            _input = new DefaultInput();
            _mover = new Mover(rigidbody: GetComponent<Rigidbody>());
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
                _mover.FixedTick();
            }
        }
    }
}
    


