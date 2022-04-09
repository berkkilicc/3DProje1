using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public event System.Action OnGameOver;

        private void Awake()
        {
           
           

        }

        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            //uzun yazimi
            //if (OnGameOver != null)
            //{
            //    GameOver();
            //}


            OnGameOver?.Invoke();
        }


    }

}

