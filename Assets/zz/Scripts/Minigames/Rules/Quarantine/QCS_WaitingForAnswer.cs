using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_WaitingForAnswer : QCS_QuarantineControllerStatus {

    public override void Enter()
    {
        m_endOfCountdown = Time.time + 1.5f;
        //here calculate and show the file (corrupted or safe)

    }


    public override void Update()
    {
        m_target.m_references.m_counter.text = (m_endOfCountdown - Time.time).ToString("F1");
        if (Time.time > m_endOfCountdown)
        {
            m_target.Initialize(m_target.m_caller);
            m_target.SM_GoToIdle(); //this should be this.Enter() for calculating a new corrupted/safe file
        }else
        {
            //here add +1 to counter, check if finish. If so, end game successfully. If no, this.Enter to repeat
        }
    }


    float m_endOfCountdown;
	
}
