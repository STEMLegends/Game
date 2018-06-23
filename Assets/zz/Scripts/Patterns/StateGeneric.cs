using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class StateGeneric <T> : ScriptableObject{

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Update() { }


    public StateGeneric<T> Init ( T target)
    {
        m_target = target;
        return this;
    }
   protected T m_target;
}
