using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{


    #region LISTENERS
    public void LSTR_Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LSTR_Credits() { }

    public void LSTR_SwitchDifficulty()
    {
        string difficulty = PlayerPrefs.GetString("Difficulty");
        if (difficulty == "Easy")
            difficulty = "Hard";
        else
            difficulty = "Easy";

        m_references.m_difficultyText.text = "Current difficulty " + difficulty;
        PlayerPrefs.SetString("Difficulty", difficulty);
    }

    public void LSTR_GoToDifficulty()
    {
        m_references.m_mainMenu.SetActive(false);
        m_references.m_difficultyMenu.SetActive(true);
    }

    public void LSTR_SetEasy() { }

    public void LSTR_SetHard() { }

    public void LSTR_BackToMain()
    {
        m_references.m_mainMenu.SetActive(true);
        m_references.m_difficultyMenu.SetActive(false);
    }
    #endregion



    private void Start()
    {
        string difficulty = PlayerPrefs.GetString("Difficulty");
        if (difficulty == "")
        {
            PlayerPrefs.SetString("Difficulty", "Easy");
            difficulty = "Easy";
        }

        m_references.m_difficultyText.text = "Current difficulty " + difficulty;

        Debug.Log("----");

        LSTR_BackToMain();
    }

    [SerializeField]
    MainMenuControllerReferences m_references;

    [System.Serializable]
    public class MainMenuControllerReferences
    {
        public GameObject m_mainMenu;
        public GameObject m_difficultyMenu;

        public Text m_difficultyText;
    }
}
