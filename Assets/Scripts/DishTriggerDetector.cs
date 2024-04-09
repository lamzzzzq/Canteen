using UnityEngine;
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

            // 当勺子进入饭盒后，让饭盒来处理后续逻辑
            gameObject.GetComponentInParent<FoodBoxController>().HandleToolEntry(other.gameObject);
        }
    }
}
