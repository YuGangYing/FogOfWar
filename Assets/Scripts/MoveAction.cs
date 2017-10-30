using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : MonoBehaviour {

	public Vector3 targetPos;
	public Vector3 startPos;

	Vector3 mTarget;
	Vector3 mStart;
	void Start () {
		startPos = transform.position;
		Animation anim = GetComponentInChildren<Animation> ();
		anim.Play ("Run01");
		mTarget = targetPos;
		mStart = startPos;
	}

	float duration = 3f;
	float t = 0;
	void Update () {
		if(t>=1){
			Vector3 temp = mTarget;
			mTarget = mStart;
			mStart = temp;
			t = 0;
		}
		t += Time.deltaTime / duration;
		transform.LookAt (mTarget);
		transform.position = Vector3.Lerp (mStart,mTarget,t);
	}
}
