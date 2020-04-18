using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarUI : MonoBehaviour
{
    [SerializeField]
    Text HpUIText;

    [SerializeField]
    Tower tower;
  
    // Update is called once per frame
    void Update()
    {
        HpUIText.text =  "Tower HP : " + tower.TowerHP + " / " + tower.MaxTowerHP;
    }
}
