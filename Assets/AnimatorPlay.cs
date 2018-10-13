using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animator animator = GetComponent<Animator>();

        //float starAt
        //animator.Play("AnimationName", 1, (1f / total_frames_in_animation) * desired_frame);

        float startAt = Random.Range(0f, 1f);
        animator.Play("Cascade",0,startAt );
    }
	
	
}
