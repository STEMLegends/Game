using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_Inactive : QCS_QuarantineControllerStatus
{

    public override void Enter()
    {
        m_target.gameObject.SetActive(false);
    }

    public override void Exit()
    {
        m_target.gameObject.SetActive(true);
    }

}
