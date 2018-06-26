using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuarantineController : MinigameRulesController
{

    #region STATE MANAGEMENT
    private void SM_GoToState(QCS_QuarantineControllerStatus newState)
    {
        if (m_states.m_current != null)
            m_states.m_current.Exit();
        m_states.m_current = newState;
        m_states.m_current.Enter();
    }

    public void SM_GoToIdle ()
    {
        SM_GoToState(m_states.m_idle);
    }
    public void SM_GoToCountDown()
    {
        SM_GoToState(m_states.m_countdown);
    }
    public void SM_GoToWaitingForAnswer()
    {
        SM_GoToState(m_states.m_waitingForAnswer);
    }
    #endregion
    public void LSTR_BtnSafe()
    {
        m_states.m_waitingForAnswer.HNDL_ReceiveResponse(QCS_WaitingForAnswer.QuarantineResponse.Safe);
    }
    public void LSTR_BtnDelete()
    {
        m_states.m_waitingForAnswer.HNDL_ReceiveResponse(QCS_WaitingForAnswer.QuarantineResponse.Delete);
    }


    public override void LSTR_CloseDescriptionAndStart()
    {
        base.LSTR_CloseDescriptionAndStart();
        SM_GoToCountDown();
    }

    public override void Initialize(MinigameController whoCalled)
    {
        base.Initialize(whoCalled);

        SM_GoToIdle();
        
        m_references.m_counter.text = "Respuestas " + m_currentCounter + "/" + m_requiredCounter;
    }

    private void Update()
    {
        m_states.m_current.Update();
    }
    public void Awake()
    {
        m_states.m_idle = ScriptableObject.CreateInstance<QCS_Idle>().Init(this) as QCS_Idle;
        m_states.m_countdown = ScriptableObject.CreateInstance<QCS_Countdown>().Init(this) as QCS_Countdown; 
        m_states.m_waitingForAnswer = ScriptableObject.CreateInstance<QCS_WaitingForAnswer>().Init(this) as QCS_WaitingForAnswer;
    }

     public override void Start()
    {
        base.Start();
        SM_GoToIdle();
    }
    public int m_currentCounter;
    public int m_requiredCounter;


    [SerializeField]
    QuarantineControllerStates m_states;
    public
    QuarantineControllerReferences m_references;
    public
    QuarantineControllerStencils m_stencils;

    [System.Serializable]
    public class QuarantineControllerReferences
    {
        public Image m_fileImage;
        public Text m_counter;
        public Text m_timer;

        public Animator m_countdownAnimator;
        public GameObject m_gameContainer;
    }

    [System.Serializable]
    public class QuarantineControllerStencils
    {
        public Sprite m_safeFile;
        public Sprite m_corruptedFile;
    }

    [System.Serializable]
    public class QuarantineControllerStates
    {
        public QCS_QuarantineControllerStatus m_current;
        public QCS_Idle m_idle;
        public QCS_Countdown m_countdown;
        public QCS_WaitingForAnswer m_waitingForAnswer;
    }

}
