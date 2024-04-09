using UnityEngine;

public class FoodBoxController : MonoBehaviour
{
    public GameObject[] dishes; // �洢��ͬ��Ʒ�����飬���ݱ�ǩ������Ӧ�Ĳ�Ʒ

    // ��¼��ǰ����Ĳ�Ʒ����
    private int activeDishIndex = -1;

    public void HandleToolEntry(GameObject tool)
    {
        // ��⵽���ߵı�ǩ��12345ʱ�����ݱ�ǩ������Ӧ�Ĳ�Ʒ
        string toolTag = tool.tag;

        // ��鹤�߱�ǩ��������Ӧ�Ĳ�Ʒ
        switch (toolTag)
        {
            case "1":
                EnableDish(0); // ��Ӧ��һ����Ʒ
                break;
            case "2":
                EnableDish(1); // ��Ӧ�ڶ�����Ʒ
                break;
            case "3":
                EnableDish(2); // ��Ӧ��������Ʒ
                break;
            case "4":
                EnableDish(3); // ��Ӧ���ĸ���Ʒ
                break;
            case "5":
                EnableDish(4); // ��Ӧ�������Ʒ
                break;
            default:
                Debug.Log("Unknown tool tag.");
                break;
        }
    }

    void EnableDish(int dishIndex)
    {
        // ���Ҫ����Ĳ�Ʒ�뵱ǰ����Ĳ�Ʒ��ͬ����ֱ�ӷ��أ������ٴμ���
        if (activeDishIndex == dishIndex)
        {
            return;
        }

        // �������в�Ʒ
        for (int i = 0; i < dishes.Length; i++)
        {
            // �����Ʒ����������Ҫ����Ĳ�Ʒ����������øò�Ʒ
            if (i != dishIndex)
            {
                dishes[i].SetActive(false);
            }
        }

        // ����ָ���Ĳ�Ʒ
        dishes[dishIndex].SetActive(true);

        // ���µ�ǰ����Ĳ�Ʒ����
        activeDishIndex = dishIndex;
    }
}
