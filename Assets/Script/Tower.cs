using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    UIManager UIManager;

    public int MaxTowerHP;
    public int TowerHP;

    // Start is called before the first frame update
    void Start()
    {
        TowerHP = MaxTowerHP;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Tank")
        {
            TowerHP -= 1;
        }

        if (TowerHP <= 0)
        {
            if (UIManager != null)
            {
                UIManager.ToGameLose();
            }
            Destroy(gameObject);
        }
    }
}
