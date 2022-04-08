using Project1.Inputs;
using System.Collections;
using System.Collections.Generic;
using Project1.Movements;
using Project1.Contollers;
using UnityEngine;

namespace Project1.Contollers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnspeed = 10f;
        [SerializeField] float _force = 55f;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnspeed;
        public float Force => _force;

        private void Awake()
        {            
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
        }

        private void Update()
        {
            Debug.Log(_input.LeftRight);


            //Input
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

            _leftRight = _input.LeftRight;

        }
        private void FixedUpdate()
        {
            //fizik islemleri
            if (_isForceUp)
            {
                _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);

        }
    }
}
    


