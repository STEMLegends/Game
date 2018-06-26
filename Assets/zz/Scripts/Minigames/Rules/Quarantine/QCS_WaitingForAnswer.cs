using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCS_WaitingForAnswer : QCS_QuarantineControllerStatus {

    public override void Enter()
    {
        m_endOfCountdown = Time.time + 1.5f;
        //here calculate and show the file (corrupted or safe)
        m_thisResponse = (QuarantineResponse)Random.Range(0, 2);
        BH_SetSprites();
        Debug.Log("--QUARANTINE RESPONSE --" + m_thisResponse);


    }


    public override void Update()
    {
        m_target.m_references.m_timer.text = (m_endOfCountdown - Time.time).ToString("F1");
        if (Time.time > m_endOfCountdown)
        {
            m_target.Initialize(m_target.m_caller);
            m_target.SM_GoToCountDown();
        }else
        {
            //here add +1 to counter, check if finish. If so, end game successfully. If no, this.Enter to repeat
        }
    }

    private void BH_SetSprites()
    {
        switch (m_thisResponse)
        {
            case QuarantineResponse.Delete:
                m_target.m_references.m_fileImage.sprite = m_target.m_stencils.m_corruptedFile;
                break;
            case QuarantineResponse.Safe:
                m_target.m_references.m_fileImage.sprite = m_target.m_stencils.m_safeFile;
                break;
        }
    }

    private void BH_ResolveAsError()
    {
        m_target.m_currentCounter = 0;
        m_target.SM_GoToCountDown();

    }

    private void BH_ResolveAsHit() {
        m_target.m_currentCounter++;
        if (m_target.m_currentCounter >= m_target.m_requiredCounter)
            Debug.Log("Go to state game won"); //where the minigame will deactivate itself
        else
            m_target.SM_GoToCountDown();


    }

    public void HNDL_ReceiveResponse (QuarantineResponse response)
    {
        if (response == m_thisResponse)
            BH_ResolveAsHit();
        else
            BH_ResolveAsError();

        m_target.m_references.m_counter.text = m_target.m_currentCounter + "/" + m_target.m_requiredCounter;
    }
    
    float m_endOfCountdown;
    QuarantineResponse m_thisResponse;
    


	public enum QuarantineResponse { Safe, Delete}
}


