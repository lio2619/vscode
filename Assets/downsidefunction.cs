using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downsidefunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D mou)		
	{
		if(mou.tag == "ementy"){		//怪物碰到下面的邊界消失
			Destroy(mou.gameObject);
		}
	}
}
