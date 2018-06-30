using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_Countdown : QCS_QuarantineControllerStatus {
    public override void Enter()
    {
        m_target.m_references.m_countdownAnimator.gameObject.SetActive(true);
        m_target.m_gameContainer.SetActive(false);
        m_target.m_references.m_countdownAnimator.Play("Countdown");
    }

    public override void Exit()
    {
        m_target.m_references.m_countdownAnimator.gameObject.SetActive(false);
        m_target.m_references.m_gameContainer.SetActive(true);
    }

}
