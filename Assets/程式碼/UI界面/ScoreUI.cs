using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    Score score;

    [SerializeField]
    Text ScoreText;

    private void Update()
    {
        // 更新分數數值
        ScoreText.text = "分數：" + score.gameScore.ToString();
    }
}
