using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MCS_Waiting : MCS_MinigameControllerState {  

    public override void Enter()
    {
        m_target.OnPlayerEnterMinigame += m_target.SM_GoToInMinigame;
    }



    public override void Exit()
    {
        m_target.OnPlayerEnterMinigame -= m_target.SM_GoToInMinigame;
    }



}
