using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("------ game scene started on difficulty " + PlayerPrefs.GetString("Difficulty"));	
	}



    public GameControllerReferences m_references;

    [System.Serializable]
    public class GameControllerReferences
    {
        public Platformer2DUserControl m_userControl;
    }

}
