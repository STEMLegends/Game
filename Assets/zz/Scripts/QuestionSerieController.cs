using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSerieController : MonoBehaviour {



    public void BH_LoadNewQuestion ()
    {
        //TODO:: get a random question from the list and remove it. In this way there will be no repeated questions
    }

    public void LSTR_AnswerSelected ()
    {
        //TODO:: if right then check if it was the last and. if wrong then reset puzzle
    }

    public void BH_InitializeSerie ()
    {
        //TODO:: on scene load, load ALL data from the scriptable in a list
    }




    int m_currentQuestion = 0;
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

        public QuestionsListScriptableData m_questionsData;
    }

    
}
