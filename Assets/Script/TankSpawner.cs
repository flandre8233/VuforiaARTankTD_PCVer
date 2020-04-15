using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    /// <summary>
    /// 坦克的Prefab
    /// </summary>
    [SerializeField]
    GameObject TankPrefab;

    [SerializeField]
    GameObject SpawnParent;

    [SerializeField]
    Tower tower;

    [SerializeField]
    GameObject[] spawnPoints;
    private void Start()
    {
        InvokeRepeating("SpawnTank", 0.1f, 0.5f);
    }

    public Vector3 getRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }

    /// <summary>
    /// 坦克生成器
    /// </summary>
    void SpawnTank()
    {
        //如果遊戲未開始就不做生成敵人
        //生成坦克
        GameObject SpawnedObj = Instantiate(TankPrefab, SpawnParent.transform);
        //為這剛生成的坦克設定他的坐標（因為極坐標輸出是以0,0作中心點，而塔就在GameGround的正中央，所以可以把極坐標數值設定至坦克localPosition而不是世界坐標
        SpawnedObj.transform.position = getRandomSpawnPoint();
        SpawnedObj.transform.LookAt(tower.transform);
    }

}
