using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MCS_Waiting : MCS_MinigameControllerState {  

    public override void Enter()
    {
        m_target.OnPlayerEnterMinigame += m_target.SM_GoToInMinigame;

        if (m_target.m_references.m_particlesResolved != null)
            m_target.m_references.m_particlesResolved.Stop();
    }



    public override void Exit()
    {
        m_target.OnPlayerEnterMinigame -= m_target.SM_GoToInMinigame;
    }



}
