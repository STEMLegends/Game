using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuarantineController : MinigameRulesController
{
    public override void Initialize(MinigameController whoCalled)
    {
          base.Initialize(whoCalled);

        base.Initialize(whoCalled);


        m_currentCounter = 0;
        m_references.m_counter.text = "Respuestas " + m_currentCounter + "/" + m_requiredCounter;
    }


    int m_currentCounter;
    public int m_requiredCounter;


    [SerializeField]
    QuarantineControllerReferences m_references;
    [SerializeField]
    QuarantineControllerStencils m_stencils;

    [System.Serializable]
    public class QuarantineControllerReferences
    {
        public Image m_fileImage;
        public Text m_counter;

        public Animator m_countdownAnimator;
    }

    [System.Serializable]
    public class QuarantineControllerStencils
    {
        public Sprite m_safeFile;
        public Sprite m_corruptedFile;
    }
}
