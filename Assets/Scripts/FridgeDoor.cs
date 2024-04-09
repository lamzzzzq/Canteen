using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    public bool isOpen = false;
    public bool isAnimating = false;

    public bool isOpenSecond = false;
    public bool isAnimatingSecond = false;

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

    public void TartDoorAction()
    {
        if (!isOpen && !isAnimating)
        {
            StartCoroutine(AnimateDoorSecond("TartDoorOpen"));
        }
        else if (isOpen && !isAnimating)
        {
            StartCoroutine(AnimateDoorSecond("TartDoorClose"));
        }
    }

    private IEnumerator AnimateDoorSecond(string animationName)
    {
        isAnimatingSecond = true; // ���ö������ű�־Ϊ true����ֹ������������

        // ���Ŷ���
        this.GetComponent<Animator>().Play(animationName);

        // �ȴ������������
        yield return new WaitForSeconds(this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

        // ���ö������ű�־Ϊ false����������һ�ζ�������
        isAnimatingSecond = false;

        // �����ŵ�״̬
        isOpenSecond = !isOpenSecond;
    }
}
