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

    private void Start()
    {
        InvokeRepeating("SpawnTank", 0.1f, 0.5f);
    }

    /// <summary>
    /// 隨機求得在中心點（0,0）的圓形坐標
    /// </summary>
    /// <returns>輸出一個隨機後的極坐標</returns>
    Vector3 CircleRandomPoint()
    {
        //給極坐標隨機數據
        Vector2 Polar = PolarToCartesian(Random.Range(0, 360f), Random.Range(3, 5f));
        return new Vector3(Polar.x, 0, Polar.y);
    }

    /// <summary>
    /// 極坐標運算
    /// </summary>
    /// <param name="angle">角度</param>
    /// <param name="radius">半徑距離</param>
    /// <returns>輸出極坐標</returns>
    public static Vector2 PolarToCartesian(float angle, float radius)
    {
        float angleRad = (Mathf.PI / 180.0f) * (angle - 90f);
        float x = radius * Mathf.Cos(angleRad);
        float y = radius * Mathf.Sin(angleRad);
        return new Vector2(x, y);
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
        SpawnedObj.transform.localPosition = CircleRandomPoint();
        SpawnedObj.transform.LookAt(tower.transform);
    }

}
