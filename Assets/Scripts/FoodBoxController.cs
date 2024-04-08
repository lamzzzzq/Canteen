using UnityEngine;

public class FoodBoxController : MonoBehaviour
{
    public GameObject[] dishes; // �洢��ͬ��Ʒ�����飬���ݱ�ǩ������Ӧ�Ĳ�Ʒ

    void OnTriggerEnter(Collider other)
    {
        // ��⵽���ߵı�ǩ��12345ʱ�����ݱ�ǩ������Ӧ�Ĳ�Ʒ
        string toolTag = other.gameObject.tag;

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

        // �����ߵı�ǩ����ΪĬ�ϱ�ǩ
        other.gameObject.tag = "Tool";
    }

    void EnableDish(int dishIndex)
    {
        // ��鵱ǰ����Ĳ�Ʒ
        foreach (GameObject dish in dishes)
        {
            // �����Ʒ�Ѿ������Ҫ�ٴν�����
            if (dish.activeSelf)
            {
                return;
            }
        }

        // �������в�Ʒ
        foreach (GameObject dish in dishes)
        {
            dish.SetActive(false);
        }

        // �����Ӧ�Ĳ�Ʒ
        dishes[dishIndex].SetActive(true);
    }
}