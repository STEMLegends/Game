using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataContainers : Singleton <DataContainers> {

    protected DataContainers() { }

    public QuestionScriptableData HNDL_GetRandomQuestion ()
    {
        if (m_allQuestions.Count == 0)
            FeedQuestionlist();

        int i = Random.Range(0, m_allQuestions.Count);
        QuestionScriptableData m_randomQuestion = m_allQuestions[i];
        m_allQuestions.RemoveAt(i);
        return m_randomQuestion;
    }

    public QuestionScriptableData HNDL_GetRandomFormula()
    {
        if (m_allFormulas.Count == 0)
            FeedFormulalist();

        int i = Random.Range(0, m_allFormulas.Count);
        QuestionScriptableData m_randomFormula = m_allFormulas[i];
        m_allFormulas.RemoveAt(i);
        return m_randomFormula;
    }


    void FeedQuestionlist ()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            foreach (QuestionScriptableData item in m_questionListDataEasySource.m_questionsList)
            {
                m_allQuestions.Add(item);
            }
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            foreach (QuestionScriptableData item in m_questionListDataHardSource.m_questionsList)
            {
                m_allQuestions.Add(item);
            }
        }


            Debug.Log("-----");
    }

    void FeedFormulalist()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            foreach (QuestionScriptableData item in m_formulaListDataEasySource.m_questionsList)
            {
                m_allFormulas.Add(item);
            }
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            foreach (QuestionScriptableData item in m_formulaListDataHardSource.m_questionsList)
            {
                m_allFormulas.Add(item);
            }
        }


        Debug.Log("-----");
    }



    private void Start()
    {
        
        FeedQuestionlist();
        FeedFormulalist();

    }
    [SerializeField]
    QuestionsListScriptableData m_questionListDataEasySource;
    [SerializeField]
    QuestionsListScriptableData m_questionListDataHardSource;

    [SerializeField]
    QuestionsListScriptableData m_formulaListDataEasySource;
    [SerializeField]
    QuestionsListScriptableData m_formulaListDataHardSource;


    public List<QuestionScriptableData> m_allQuestions = new List<QuestionScriptableData>();
    public List<QuestionScriptableData> m_allFormulas = new List<QuestionScriptableData>();

}
