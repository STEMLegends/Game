using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class FloatingPatrolSMB : SceneLinkedSMB<EnemyBehaviour>
    {
        public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateEnter(animator, stateInfo, layerIndex);

            m_MonoBehaviour.OrientToTarget();
        }


        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            m_MonoBehaviour.ScanForPlayer();
        }
    }
}