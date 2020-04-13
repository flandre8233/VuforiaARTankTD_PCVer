using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHPBar : MonoBehaviour
{
    [SerializeField]
    SimpleHealthBar SimpleHealthBar;

    [SerializeField]
    Tower Tower;

    // Update is called once per frame
    void Update()
    {
        SimpleHealthBar.UpdateBar(Tower.TowerHP, Tower.MaxTowerHP);
    }
}