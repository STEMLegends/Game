using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameRulesController : MonoBehaviour {

    public void LSTR_CloseDescriptionAndStart()
    {
        m_gameContainer.SetActive(true);
        m_descriptionContainer.SetActive(false);
    }
    public virtual void Initialize (MinigameController whoCalled)
    {
        m_caller = whoCalled;
        gameObject.SetActive(true);
        m_gameContainer.SetActive(false);
        m_descriptionContainer.SetActive(true);
    }


    private void Start()
    {
        gameObject.SetActive(false);
    }
    public MinigameController m_caller;

    public GameObject m_descriptionContainer;
    public GameObject m_gameContainer;
}
