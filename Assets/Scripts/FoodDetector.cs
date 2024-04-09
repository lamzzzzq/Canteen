using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FoodDetector : MonoBehaviour
{
    public Character_2 character;
    public Character_2 character_2;
    public GameObject character2;

    // 触发器
    private void OnTriggerEnter(Collider other)
    {
        // 检查进入触发器的物体是否带有 "Coke" 标签
        if (other.CompareTag("Coke"))
        {
            // 隐藏进入触发器的物体
            other.gameObject.SetActive(false);

            //npc走开
            character.runToPosition();
            //npc走进并说话
            character_2.runToPosition();
            foreach (var trigger in character2.GetComponents<DialogueSystemTrigger>())
            {
                trigger.OnUse();
            }
        }
    }
}