using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCS_Resolved : MCS_MinigameControllerState
{

    public override void Enter()
    {

        m_target.m_references.m_mainSprite.sprite = m_target.m_stencils.m_resolvedSprite;
        m_target.m_gameController.SM_GoToPlayingScroller();
        m_target.m_references.m_collider.enabled = false;
    }
}
