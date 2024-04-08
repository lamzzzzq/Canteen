using UnityEngine;
using PixelCrushers;
using PixelCrushers.DialogueSystem;

public class TriggerDetector : MonoBehaviour
{
    private bool lemonTriggered = false;
    private bool orderTriggered = false;

    public BossOnPlayer bossScript;

    public GameObject mealOnDesk;
    public GameObject meal;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LemonTea") && !lemonTriggered)
        {
            lemonTriggered = true;
            CheckTriggersAndExecute();
        }
        else if (other.CompareTag("Order") && !orderTriggered)
        {
            orderTriggered = true;
            CheckTriggersAndExecute();
            meal.SetActive(false); 
            mealOnDesk.SetActive(true);
        }
    }

    void CheckTriggersAndExecute()
    {
        if (lemonTriggered && orderTriggered)
        {
            functionA();

            // 执行后将标志设置为 false，以确保不再执行
            lemonTriggered = false;
            orderTriggered = false;
        }
    }

    void functionA()
    {
        // 执行您的功能代码
        Debug.Log("Function A executed.");
        QuestLog.SetQuestState("Boss_Third", QuestState.Active);
        bossScript.talkToBossThird();
    }
}
