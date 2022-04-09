using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Project1.Managers;

namespace Project1.Contollers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player =null)
            {
                return;
            }
            if (other.GetContact(0).normal.y == 0)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //GameOver
                GameManager.Instance.GameOver();

            }
        }
    }
}


