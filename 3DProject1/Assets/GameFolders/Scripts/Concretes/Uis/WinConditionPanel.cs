using Project1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Uis
{
    public class WinConditionPanel : MonoBehaviour
    {
       public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}
