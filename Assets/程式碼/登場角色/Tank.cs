using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public GameObject explosionEffectObject;

    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        //看著塔
        transform.Translate(0,0, speed * Time.deltaTime);
    }

 
    public void SpawnExpEffect()
    {
        //生成出爆炸特效
        GameObject Effect = Instantiate(explosionEffectObject, transform.position, Quaternion.identity);
        Destroy(Effect, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tower")
        {
            OnDead();
        }
    }

    public void OnDead()
    {
        //移除該坦克
        Destroy(gameObject);
        SpawnExpEffect();
    }

}
