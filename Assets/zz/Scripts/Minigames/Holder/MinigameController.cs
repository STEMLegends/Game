using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameController : MonoBehaviour {


    #region LISTENERS
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Trigger");
        if (collision.tag == "Player")
        {
            if (OnPlayerEnterMinigame != null)
                OnPlayerEnterMinigame();
        }
    }
    #endregion

    
    #region state management
    private void SM_GoToState(MCS_MinigameControllerState newState)
    {
        if (m_states.m_current != null)
            m_states.m_current.Exit();
        m_states.m_current = newState;
        m_states.m_current.Enter();
    }

    public void SM_GoToWaiting ()
    {
        SM_GoToState(m_states.m_waiting);
    }

    public void SM_GoToInMinigame ()
    {
        SM_GoToState(m_states.m_inMinigame);
    }
    public void SM_GoToResolved ()
    {
        SM_GoToState(m_states.m_resolved);
    }

   
    #endregion

    #region HANDLERS
   public void HNDL_EndAsVictory()
    {

    }

    public void HNDL_EndAsDefeat () { }
    
    #endregion

    public virtual void BH_FindTargetRules ()
    {

    }

    private void Update()
    {
        m_states.m_current.Update();
    }
    private void Start()
    {
        SM_GoToWaiting();
    }
    private void Awake()
    {
        m_states.m_waiting = ScriptableObject.CreateInstance<MCS_Waiting>().Init(this) as MCS_Waiting;
        m_states.m_inMinigame = ScriptableObject.CreateInstance<MCS_InMinigame>().Init(this) as MCS_InMinigame;
        m_states.m_resolved = ScriptableObject.CreateInstance<MCS_Resolved>().Init(this) as MCS_Resolved;

        m_gameController = FindObjectOfType<GameController>();
        m_rules = gameObject.GetComponent<IMinigameable>();

        Debug.Log("");

    }

    
    public delegate void PlayerEntersMinigame();
    public event PlayerEntersMinigame OnPlayerEnterMinigame;


    public IMinigameable m_rules;

    [SerializeField]
    MinigameControllerStates m_states;
    public
    MinigameControllerReferences m_references;
    public
    MinigameControllerStencils m_stencils;

    [HideInInspector]
    public GameController m_gameController;

    [System.Serializable]
    public class MinigameControllerReferences
    {
        public SpriteRenderer m_mainSprite;
        public BoxCollider2D m_collider;
        public ParticleSystem m_particles;
        public ParticleSystem m_particlesResolved;   
    }

    [System.Serializable]
    public class MinigameControllerStencils
    {
        public Sprite m_resolvedSprite;
    }

    [System.Serializable]
    public class MinigameControllerStates
    {[SerializeField]
        public MCS_MinigameControllerState m_current;
        public MCS_Waiting m_waiting;
        public MCS_InMinigame m_inMinigame;
        public MCS_Resolved m_resolved;
    }


   

}
