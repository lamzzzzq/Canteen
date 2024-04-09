using UnityEngine;

public class FoodBoxController : MonoBehaviour
{
    public GameObject[] dishes; // 存储不同菜品的数组，根据标签激活相应的菜品

    // 记录当前激活的菜品索引
    private int activeDishIndex = -1;

    public void HandleToolEntry(GameObject tool)
    {
        // 检测到工具的标签是12345时，根据标签激活相应的菜品
        string toolTag = tool.tag;

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
    }

    void EnableDish(int dishIndex)
    {
        // 如果要激活的菜品与当前激活的菜品相同，则直接返回，无需再次激活
        if (activeDishIndex == dishIndex)
        {
            return;
        }

        // 遍历所有菜品
        for (int i = 0; i < dishes.Length; i++)
        {
            // 如果菜品索引不等于要激活的菜品索引，则禁用该菜品
            if (i != dishIndex)
            {
                dishes[i].SetActive(false);
            }
        }

        // 激活指定的菜品
        dishes[dishIndex].SetActive(true);

        // 更新当前激活的菜品索引
        activeDishIndex = dishIndex;
    }
}
