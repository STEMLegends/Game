using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        //transform.position = m_target.transform.position * m_speedFactor + m_initialOffset;
        transform.position = new Vector3(m_target.transform.position.x * m_speedFactor.x, m_target.transform.position.y * m_speedFactor.y, m_target.transform.position.z * m_speedFactor.z) + m_initialOffset;
	}


    private void Start()
    {

        transform.position = new Vector3(m_target.position.x, m_target.position.y, transform.position.z);
        m_initialOffset = transform.position - m_target.position;
    }



    public Transform m_target;
    public Vector3 m_speedFactor;


    Vector3 m_initialOffset;
}
