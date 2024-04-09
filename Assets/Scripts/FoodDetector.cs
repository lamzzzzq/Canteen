using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FoodDetector : MonoBehaviour
{
    public Character_2 character;
    public Character_2 character_2;
    public GameObject character2;

    // ������
    private void OnTriggerEnter(Collider other)
    {
        // �����봥�����������Ƿ���� "Coke" ��ǩ
        if (other.CompareTag("Coke"))
        {
            // ���ؽ��봥����������
            other.gameObject.SetActive(false);

            //npc�߿�
            character.runToPosition();
            //npc�߽���˵��
            character_2.runToPosition();
            foreach (var trigger in character2.GetComponents<DialogueSystemTrigger>())
            {
                trigger.OnUse();
            }
        }
    }
}