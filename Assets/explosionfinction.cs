using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionfinction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AnimationEnd(){
		Destroy(gameObject);		//動畫結束
	}
}
