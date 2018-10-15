using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterDataController : MonoBehaviour {


    public void BTN_Next ()
    {

    }

    public void BTN_Prev ()
    {

    }

    public void BH_DisplayForList ()
    {

        m_btnNext.gameObject.SetActive(false);
        m_btnPrev.gameObject.SetActive(false);

        gameObject.SetActive(true);
    }

    public void BH_DisplayForSingle ()
    {

    }


    private void Start()
    {
        gameObject.SetActive(false);
    }


    [SerializeField] Button m_btnNext;
    [SerializeField] Button m_btnPrev;


}
