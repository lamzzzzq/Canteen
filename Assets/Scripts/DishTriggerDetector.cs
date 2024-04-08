using UnityEngine;
using PixelCrushers;
using PixelCrushers.DialogueSystem;

public class DishTriggerDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tool"))
        {
            if (gameObject.name == "eggplant_Trigger")
            {
                other.gameObject.tag = "1";
            }
            else if (gameObject.name == "tofu_Trigger")
            {
                other.gameObject.tag = "2";
            }
            else if (gameObject.name == "Zucchini_Trigger")
            {
                other.gameObject.tag = "3";
            }
            else if (gameObject.name == "chicken_Trigger")
            {
                other.gameObject.tag = "4";
            }
            else if (gameObject.name == "rice_Trigger")
            {
                other.gameObject.tag = "5";
                QuestLog.SetQuestState("FenQuest", QuestState.ReturnToNPC);
            }
            // 同样的逻辑继续适用于其他炉子或者饭盒
        }
    }
}
