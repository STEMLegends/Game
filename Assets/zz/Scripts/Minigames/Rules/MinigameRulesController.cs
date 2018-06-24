using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameRulesController : MonoBehaviour {


    public virtual void Initialize (MinigameController whoCalled)
    {
        m_caller = whoCalled;
    }
    public MinigameController m_caller;
}
