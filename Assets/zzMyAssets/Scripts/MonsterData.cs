using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "__MonsterData__", menuName = "LoS/Create Monster Data", order = 1)]
public class MonsterData : ScriptableObject {

    public string m_name;
    public string m_description;
    public Sprite m_image;
}
