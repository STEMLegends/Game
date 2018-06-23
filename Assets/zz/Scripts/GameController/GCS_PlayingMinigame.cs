using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCS_PlayingMinigame : StateGeneric<GameController> {


    public override void Enter()
{
        m_target.m_references.m_userControl.enabled = true;
}
}
