using Project1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
      public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }


        public void NoClicked()
        {

            GameManager.Instance.LoadMenuScene();
        }

    }

}

