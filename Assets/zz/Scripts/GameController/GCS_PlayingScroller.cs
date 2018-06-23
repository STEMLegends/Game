using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCS_PlayingScroller : GCS_GameControllerState
{


    public override void Enter()
    {
        m_target.m_references.m_characterController.m_MaxSpeed = 10;
    }


    public override void Exit()
    {
        m_target.m_references.m_characterController.m_MaxSpeed = 0;
    }


}
