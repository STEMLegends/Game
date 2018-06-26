using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_Idle : QCS_QuarantineControllerStatus {
    public override void Enter()
    {
        m_target.m_currentCounter = 0;
        m_target.m_references.m_gameContainer.SetActive(false);
        m_target.m_references.m_countdownAnimator.gameObject.SetActive(false);
    }

}
