using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartButton : MonoBehaviour
{
    [SerializeField]
    GameObject SightingUI;

    [SerializeField]
    GameObject gameManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        //隱藏這按鈕
        gameObject.SetActive(false);
        //開準星
        SightingUI.SetActive(true);
        //讓遊戲開始運作
        gameManager.SetActive(true);
    }

}
