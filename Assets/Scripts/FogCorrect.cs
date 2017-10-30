using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogCorrect : MonoBehaviour {

	public Transform fog;
	public Vector3 offset = new Vector3 (0,3,0);
	void Start () {
		
	}
	
	void LateUpdate () {
		if(fog != null){
			RaycastHit hit;
			if (Physics.Raycast (Camera.main.transform.position ,(transform.position + offset -  Camera.main.transform.position).normalized,out hit,Mathf.Infinity)) {
				fog.transform.position = hit.point;
			}
		}
	}
}
