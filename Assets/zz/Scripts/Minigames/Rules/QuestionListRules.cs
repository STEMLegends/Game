using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionListRules : MonoBehaviour, IMinigameable {
    public void StartMinigame(MinigameController caller)
    {
        m_questionSerieController.Initialize(caller, m_type);
    }

    private void Awake()
    {
        m_questionSerieController = FindObjectOfType<QuestionSerieController>();
    }




    [SerializeField] QuestionSerieController.QuestionMinigameType m_type;
    QuestionSerieController m_questionSerieController; 
}
