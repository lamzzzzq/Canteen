using UnityEngine;

public class RandomAnimationDelay : MonoBehaviour
{
    public Animator animator;

    // 最小和最大延迟时间
    public float minDelay = 0f;
    public float maxDelay = 2f;

    void Start()
    {
        // 使用Invoke延迟调用播放动画
        float delay = Random.Range(minDelay, maxDelay);
        Invoke("PlayIdleAnimation", delay);
    }

    void PlayIdleAnimation()
    {
        // 将默认状态切换到 "idle" 状态
        animator.Play("IdleReal");
    }
}
