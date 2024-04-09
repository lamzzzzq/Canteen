using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCode : MonoBehaviour
{

    public BossOnPlayer boss;

    public GameObject parent;

    private int cleanedDirtCount = 0; // ��¼����� dirt ����

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mop")) // ����Ĩ���ı�ǩΪ "Cloth"
        {
            CleanDirt();
        }
    }

    void CleanDirt()
    {
        // ��Ĩ��������һ�� dirt ʱ��ʹ�� dirt ��ʧ
        parent.SetActive(false); // ���� Destroy(gameObject) �����ٸ� dirt ����

        // ��������� dirt ����
        ExecuteFunction();
    }

    void ExecuteFunction()
    {
        // ִ������Ҫִ�е� function
        Debug.Log("Execute function when 3 dirt are cleaned.");
        boss.talkToBossSeven();

    }
}
