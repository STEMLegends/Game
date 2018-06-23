using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCS_InMinigame : MCS_MinigameControllerState
{

    public override void Enter()
    {
        m_target.m_gameController.SM_GoToPlayingMinigame();
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            m_target.SM_GoToResolved();
    }

    public override void Exit()
    {
        m_target.m_gameController.SM_GoToPlayingScroller();
    }
}
