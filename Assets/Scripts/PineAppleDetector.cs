using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PineAppleDetector : MonoBehaviour
{
    public GameObject PineAppleNPC;

    public BossOnPlayer boss;
    private void OnTriggerEnter(Collider other)
    {
        // �����봥�����������Ƿ���� "Coke" ��ǩ
        if (other.CompareTag("PineApple"))
        {
            // ���ؽ��봥����������
            other.gameObject.SetActive(false);

            PineAppleNPC.SetActive(false);

            boss.talkToBossSix();
            
        }
    }
}
