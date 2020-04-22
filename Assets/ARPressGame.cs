using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class ARPressGame : MonoBehaviour
{
    /// <summary>
    /// 取得本場景所使用的AR圖片元件
    /// </summary>
    [SerializeField]
    ImageTargetBehaviour ARImage;

    // Update is called once per frame
    void Update()
    {
        //檢查當前AR圖片
        if (CheckIsDetectAR() )
        {
            //存在AR圖片就繼續運行遊戲
            Time.timeScale = 1;
        }
        else
        {
            //不存在AR圖片就先暫停遊戲
            Time.timeScale = 0;
        }
    }

    /// <summary>
    /// 檢查當前AR圖片有沒有被偵測到
    /// </summary>
    bool CheckIsDetectAR()
    {
        if (ARImage.CurrentStatus == TrackableBehaviour.Status.DETECTED ||
             ARImage.CurrentStatus == TrackableBehaviour.Status.TRACKED ||
             ARImage.CurrentStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            return true;
        }
        return false;
    }
}
