using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionListRules : MonoBehaviour, IMinigameable  {
    public void StartMinigame(MinigameController caller)
    {
        m_questionSerieController.Initialize(caller);
    }
    
    private void Awake()
    {
        m_questionSerieController = FindObjectOfType<QuestionSerieController>();
    }

    

    

    QuestionSerieController m_questionSerieController; 
}
