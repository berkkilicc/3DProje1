using Project1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project1.Contollers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent < PlayerController> ();

            if (player !=null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

