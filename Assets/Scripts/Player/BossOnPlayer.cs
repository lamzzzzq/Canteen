using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using PixelCrushers.DialogueSystem;

public class BossOnPlayer : MonoBehaviour
{
    public TeleportPlayerFade teleport;
    public ScreenFader screenFader;
    public Transform bossTalkPosition;
    public GameObject boss;

    public CharacterController playerController;

    public GameObject characterTart;
    public void talkToBoss()
    {
        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossAgain()
    {
        QuestLog.SetQuestState("Boss_Second", QuestState.Success);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    private IEnumerator endConversationAndTeleport()
    {
        yield return new WaitForSeconds(0.5f);
        //talk
        foreach (var item in boss.GetComponents<DialogueSystemTrigger>())
        {
            item.OnUse();
        }
    }

    public void enableController()
    {
        playerController.enabled = true;
    }

    public void disableController()
    {
        playerController.enabled = false;
    }

    public void talkToBossThird()
    {

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossFourth()
    {
        QuestLog.SetQuestState("Boss_Third", QuestState.Grantable);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossFifth()
    {
        disableController();

        //退出点餐，去和boss聊天
        QuestLog.SetQuestState("Boss_Third", QuestState.Success);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void TartNPCShow()
    {
        characterTart.SetActive(true);

        StartCoroutine(npcDelayShow());
    }

    public void talkAfterTart()
    {
        QuestLog.SetQuestState("Boss_Fifth", QuestState.Active);


    }

    private IEnumerator npcDelayShow()
    {
        yield return new WaitForSeconds(0.5f);
        //talk
        foreach (var item in characterTart.GetComponents<DialogueSystemTrigger>())
        {
            item.OnUse();
        }
    }

    public void talkToBossSix()
    {
        disableController();

        //给了蛋挞之后
        QuestLog.SetQuestState("Boss_Fifth", QuestState.Active);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

}
