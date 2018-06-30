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





    private void Start()
    {
        
        FeedQuestionlist();

    }
    [SerializeField]
    QuestionsListScriptableData m_questionListDataEasySource;
    [SerializeField]
    QuestionsListScriptableData m_questionListDataHardSource;

    public List<QuestionScriptableData> m_allQuestions = new List<QuestionScriptableData>();

}
