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
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnspeed;
        public float Force => _force;

        private void Awake()
        {            
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Update()
        {
            Debug.Log(_input.LeftRight);


            //Input
            if (_input.IsForceUp && _fuel.IsEmpty )
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelDecrease(0.01f);
            }

            _leftRight = _input.LeftRight;

        }
        private void FixedUpdate()
        {
            //fizik islemleri
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);

        }
    }
}
    


