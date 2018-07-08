using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCS_Resolved : MCS_MinigameControllerState
{

    public override void Enter()
    {

        m_target.m_references.m_mainSprite.sprite = null;
        m_target.m_gameController.SM_GoToPlayingScroller();
        m_target.m_references.m_collider.enabled = false;
		if (m_target.m_references.m_particles) {
			m_target.m_references.m_particles.Stop ();
		}
    }
}
