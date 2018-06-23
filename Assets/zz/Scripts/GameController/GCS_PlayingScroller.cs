using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCS_PlayingScroller : StateGeneric<GameController> {


    public override void Enter()
    {
        m_target.m_references.m_userControl.enabled = false;
    }


}
