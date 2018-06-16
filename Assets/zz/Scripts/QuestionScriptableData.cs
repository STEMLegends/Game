using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "__NewQuestion__", menuName = "LoS/DataGenerators/Question", order = 1)]
public class QuestionScriptableData : ScriptableObject {

    public string m_question;
    public string[] m_answer;

    public int m_idRightAnswer;
}
