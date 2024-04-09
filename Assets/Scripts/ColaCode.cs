using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCode : MonoBehaviour
{

    public BossOnPlayer boss;

    private int cleanedDirtCount = 0; // 记录清理的 dirt 数量

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mop")) // 假设抹布的标签为 "Cloth"
        {
            CleanDirt();
        }
    }

    void CleanDirt()
    {
        // 当抹布清理了一个 dirt 时，使该 dirt 消失
        gameObject.SetActive(false); // 或者 Destroy(gameObject) 来销毁该 dirt 对象

        // 增加清理的 dirt 数量
        cleanedDirtCount++;

        // 当清理的 dirt 数量达到 3 时，执行 function
        if (cleanedDirtCount == 3)
        {
            ExecuteFunction();
        }
    }

    void ExecuteFunction()
    {
        // 执行你想要执行的 function
        Debug.Log("Execute function when 3 dirt are cleaned.");
        boss.talkToBossSeven();

    }
}
