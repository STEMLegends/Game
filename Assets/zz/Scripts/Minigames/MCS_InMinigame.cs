using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCS_InMinigame : MCS_MinigameControllerState
{

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            m_target.SM_GoToResolved();
    }
}
