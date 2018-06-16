using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "__NewQuestionList__", menuName = "LoS/DataGenerators/QuestionsList", order = 1)]
    public class QuestionsListScriptableData : ScriptableObject
{

    public QuestionScriptableData[] m_questionsList;
}
