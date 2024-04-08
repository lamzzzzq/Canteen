using UnityEngine;

public class RandomAnimationDelay : MonoBehaviour
{
    public Animator animator;

    // ��С������ӳ�ʱ��
    public float minDelay = 0f;
    public float maxDelay = 2f;

    void Start()
    {
        // ʹ��Invoke�ӳٵ��ò��Ŷ���
        float delay = Random.Range(minDelay, maxDelay);
        Invoke("PlayIdleAnimation", delay);
    }

    void PlayIdleAnimation()
    {
        // ��Ĭ��״̬�л��� "idle" ״̬
        animator.Play("IdleReal");
    }
}
