using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_Idle : QCS_QuarantineControllerStatus {
    public override void Enter()
    {
        m_target.m_currentCounter = 0;
    }

}
