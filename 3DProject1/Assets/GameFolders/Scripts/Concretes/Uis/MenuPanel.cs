using Project1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
       public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}

