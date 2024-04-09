using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PineAppleDetector : MonoBehaviour
{
    public GameObject PineAppleNPC;

    public BossOnPlayer boss;
    private void OnTriggerEnter(Collider other)
    {
        // 检查进入触发器的物体是否带有 "Coke" 标签
        if (other.CompareTag("PineApple"))
        {
            // 隐藏进入触发器的物体
            other.gameObject.SetActive(false);

            PineAppleNPC.SetActive(false);

            boss.talkToBossSix();
            
        }
    }
}
