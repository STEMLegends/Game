using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataContainers : Singleton <DataContainers> {


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
        foreach (QuestionScriptableData item in m_questionListData.m_questionsList)
        {
            m_allQuestions.Add(item);
        }

        Debug.Log("-----");
    }





    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        FeedQuestionlist();
    }
    [SerializeField]
    QuestionsListScriptableData m_questionListData;
    public List<QuestionScriptableData> m_allQuestions = new List<QuestionScriptableData>();

}
