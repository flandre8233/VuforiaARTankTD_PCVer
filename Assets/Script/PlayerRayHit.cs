using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayHit : MonoBehaviour
{
    [SerializeField]
    AudioSource FireAudioSource;

    [SerializeField]
    Score score;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //播放音效
            FireAudioSource.Play();

            //求得手機晝面中心點
            Vector3 CenterScreenPoint = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
            //把手機晝面中心點轉為世界坐標
            Vector3 CenterGamePoint = Camera.main.ScreenToWorldPoint(CenterScreenPoint);

            //初設射線
            Ray ray = new Ray(CenterGamePoint, Camera.main.transform.forward * 1000);
            RaycastHit hit;
            //射線判定，結果會輸出在hit
            if (Physics.Raycast(ray, out hit, 1000))
            {
                //試在射線結果中找出坦克特徵
                Tank enemy = hit.collider.GetComponent<Tank>();

                //確定射線結果真的為坦克
                if (enemy)
                {
                    //讓他死
                    enemy.OnDead();
                    //總得分加一分
                    score.gameScore++;
                }
            }
        }

    }
}