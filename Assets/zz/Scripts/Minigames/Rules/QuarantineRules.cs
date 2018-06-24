using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarantineRules : MonoBehaviour, IMinigameable
{
    public void StartMinigame(MinigameController caller)
    {
        m_quarantineController.Initialize(caller);
    }


    private void Awake()
    {
        m_quarantineController = FindObjectOfType<QuarantineController>();
    }

    QuarantineController m_quarantineController;
}
