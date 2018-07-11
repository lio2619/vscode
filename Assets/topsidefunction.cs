using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topsidefunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)		//把超出範圍的子彈給消滅掉,要勾is trigger
	{
		if(col.tag == "Bullet"){
			Destroy(col.gameObject);
		}
	}
}
