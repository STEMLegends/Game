using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownAnimationListeners : MonoBehaviour {

    public void LSTR_EndOfAnimation ()
    {
        m_quarantineController.SM_GoToWaitingForAnswer();
    }



    public QuarantineController m_quarantineController;
}
