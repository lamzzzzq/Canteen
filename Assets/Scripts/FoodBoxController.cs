using UnityEngine;

public class FoodBoxController : MonoBehaviour
{
    public GameObject[] dishes; // 存储不同菜品的数组，根据标签激活相应的菜品

    void OnTriggerEnter(Collider other)
    {
        // 检测到工具的标签是12345时，根据标签激活相应的菜品
        string toolTag = other.gameObject.tag;

        // 检查工具标签并激活相应的菜品
        switch (toolTag)
        {
            case "1":
                EnableDish(0); // 对应第一个菜品
                break;
            case "2":
                EnableDish(1); // 对应第二个菜品
                break;
            case "3":
                EnableDish(2); // 对应第三个菜品
                break;
            case "4":
                EnableDish(3); // 对应第四个菜品
                break;
            case "5":
                EnableDish(4); // 对应第五个菜品
                break;
            default:
                Debug.Log("Unknown tool tag.");
                break;
        }

        // 将工具的标签重置为默认标签
        other.gameObject.tag = "Tool";
    }

    void EnableDish(int dishIndex)
    {
        // 检查当前激活的菜品
        foreach (GameObject dish in dishes)
        {
            // 如果菜品已经激活，则不要再次禁用它
            if (dish.activeSelf)
            {
                return;
            }
        }

        // 禁用所有菜品
        foreach (GameObject dish in dishes)
        {
            dish.SetActive(false);
        }

        // 激活对应的菜品
        dishes[dishIndex].SetActive(true);
    }
}