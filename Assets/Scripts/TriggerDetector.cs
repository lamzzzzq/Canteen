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

            // ִ�к󽫱�־����Ϊ false����ȷ������ִ��
            lemonTriggered = false;
            orderTriggered = false;
        }
    }

    void functionA()
    {
        // ִ�����Ĺ��ܴ���
        Debug.Log("Function A executed.");
        QuestLog.SetQuestState("Boss_Third", QuestState.Active);
        bossScript.talkToBossThird();
    }
}
