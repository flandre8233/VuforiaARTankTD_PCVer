using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// UI上的遊戲結束畫面畫布
    /// </summary>
    [SerializeField]
    GameObject GameLoseCanvas;

    [SerializeField]
    public GameObject SightingUI;

    // Update is called once per frame
   public  void ToGameLose()
    {
        //如果輸掉就把遊戲結束畫面輸出
            SightingUI.SetActive(false);
            GameLoseCanvas.SetActive(true);
    }
}
