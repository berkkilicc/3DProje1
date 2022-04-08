using Project1.Contollers;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Inputs;
using Project1.Movements;
using Project1.Inputs;
using UnityEngine;



namespace Project1.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;
        private Rigidbody rigidbody;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

       

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * _playerController.Force);
        }
    }
}

