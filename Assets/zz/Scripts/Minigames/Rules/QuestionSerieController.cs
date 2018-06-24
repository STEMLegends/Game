using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSerieController : MinigameRulesController
{
    


    public void BH_LoadNewQuestion ()
    {
        QuestionScriptableData randomQuestion = DataContainers.Instance.HNDL_GetRandomQuestion();
        m_references.m_questionText.text = randomQuestion.m_question;
        for (int i = 0; i < randomQuestion.m_answer.Length; i++)
        {
            m_references.m_availableAnswers[i].text = randomQuestion.m_answer[i];
        }
        m_currentQuestionRightAnswer = randomQuestion.m_idRightAnswer;
    }

    public void LSTR_AnswerSelected (int idResponse)
    {
        if (idResponse == m_currentQuestionRightAnswer)
        {
            m_currentAnswers++;
            if (m_currentAnswers == m_requiredAnswers)
            {
                m_caller.SM_GoToResolved();
                gameObject.SetActive(false);
            }

        } else
        {
            m_currentAnswers = 0;
        }

        m_references.m_questionCounter.text = "Respuestas " + m_currentAnswers + "/" + m_requiredAnswers;

        BH_LoadNewQuestion();
        //TODO:: if right then check if it was the last and. if wrong then reset puzzle
    }

    public void BH_InitializeSerie ()
    {
        //TODO:: on scene load, load ALL data from the scriptable in a list
    }

    public override void Initialize(MinigameController whoCalled)
    {
        base.Initialize(whoCalled);
        
        BH_LoadNewQuestion();
        m_currentAnswers = 0;
        m_references.m_questionCounter.text = "Respuestas " + m_currentAnswers + "/" + m_requiredAnswers;

        

    }

   

    public int m_requiredAnswers = 2;
    public int m_currentAnswers = 0;
    int m_currentQuestionRightAnswer;


    List<QuestionScriptableData> m_allQuestions;

    [SerializeField]
    int questionsInTheSerie;
    [SerializeField]
    QuestionSerieControllerReferences m_references;




    [System.Serializable]
    public class QuestionSerieControllerReferences
    {
        public Text m_questionText;
        public Text m_questionCounter;
        public Text[] m_availableAnswers;

        
    }

    
}
