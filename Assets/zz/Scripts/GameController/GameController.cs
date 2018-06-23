using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameController : MonoBehaviour {



    #region STATE MANAGEMENT
    private void SM_GoToState(GCS_GameControllerState newState)
    {
        if (m_states.m_current != null)
            m_states.m_current.Exit();
        m_states.m_current = newState;
        m_states.m_current.Enter();
    }

    public void SM_GoToPlayingScroller()
    {
        SM_GoToState(m_states.m_playingScroller);
    }

    public void SM_GoToPlayingMinigame ()
    {
        SM_GoToState(m_states.m_plaingMinigame);
        
    }

    #endregion
    // Use this for initialization
    void Start () {
        Debug.Log("------ game scene started on difficulty " + PlayerPrefs.GetString("Difficulty"));

        SM_GoToPlayingScroller();
	}



    private void Awake()
    {
        m_states.m_idle = ScriptableObject.CreateInstance<GCS_Idle>().Init(this) as GCS_Idle;
        m_states.m_playingScroller = ScriptableObject.CreateInstance<GCS_PlayingScroller>().Init(this) as GCS_PlayingScroller;
        m_states.m_plaingMinigame = ScriptableObject.CreateInstance<GCS_PlayingMinigame>().Init(this) as GCS_PlayingMinigame;

        
    }

    public GameControllerStates m_states;
    public GameControllerReferences m_references;




    [System.Serializable]
    public class GameControllerReferences
    {
        public PlatformerCharacter2D m_characterController;
    }

    [System.Serializable]
    public class GameControllerStates
    {
       public GCS_GameControllerState m_current;
        public GCS_Idle m_idle;
        public GCS_PlayingScroller m_playingScroller;
        public GCS_PlayingMinigame m_plaingMinigame;
    }

}
