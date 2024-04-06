using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    public bool isOpen = false;
    public bool isAnimating = false;

    public void DoorAction()
    {
        if (!isOpen && !isAnimating)
        {
            StartCoroutine(AnimateDoor("FridgeOpen"));
        }
        else if (isOpen && !isAnimating)
        {
            StartCoroutine(AnimateDoor("FridgeClose"));
        }
    }

    private IEnumerator AnimateDoor(string animationName)
    {
        isAnimating = true; // ���ö������ű�־Ϊ true����ֹ������������

        // ���Ŷ���
        this.GetComponent<Animator>().Play(animationName);

        // �ȴ������������
        yield return new WaitForSeconds(this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

        // ���ö������ű�־Ϊ false����������һ�ζ�������
        isAnimating = false;

        // �����ŵ�״̬
        isOpen = !isOpen;
    }
}
